
using MongoDB.Driver;
using System.Windows.Forms;

namespace Työkalupakkisovellus
{
    public partial class Form1 : Form
    {

        private VarausTiedotTab _borrowingInfo;
        private PalautusTab _returnInfo;
        private TyokalulistaTab _toolsInfo;

        private IMongoCollection<BsonDocument> _toolsCollection;
        private IMongoCollection<BsonDocument> _activeBookings;


        public Form1()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("TyokaluDB");

            _toolsCollection = database.GetCollection<BsonDocument>("Tools");
            _activeBookings = database.GetCollection<BsonDocument>("ActiveBookings");

            FillCheckedListBoxTools();
            UpdateOngoingBookingListBox();
            TickCheckedListBox();
            //PopulateToolsList();

            _borrowingInfo = new VarausTiedotTab();
            _returnInfo = new PalautusTab(palautusTyokalutListbox, korvaushintaLabel, palautaButton, palautusListbox, _borrowingInfo);
            _toolsInfo = new TyokalulistaTab("mongodb://localhost:27017/", "TyokaluDB", "Tools");
        }


        private void FillCheckedListBoxTools()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var show = Builders<BsonDocument>.Projection.Include("displayName");

            var tools = _toolsCollection.Find(filter).Project(show).ToList();

            foreach (var tool in tools)
            {
                string displayName = tool.GetValue("displayName").AsString;
                varaaTyokalut_listbox.Items.Add(displayName);
                varastoListbox.Items.Add(displayName);
            }


        }

        private void TickCheckedListBox()
        {
            for (int i = 0; i < varaaTyokalut_listbox.Items.Count; i++)
            {
                varaaTyokalut_listbox.SetItemChecked(i, true);
            }

            for (int i = 0; i < palautusTyokalutListbox.Items.Count; i++)
            {
                palautusTyokalutListbox.SetItemChecked(i, true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void lahetaVaraus_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lainaajanNimi_textBox.Text) ||
                string.IsNullOrWhiteSpace(opettajanNimi_textBox.Text) ||
                varaus_dateTimePicker.Value == DateTime.MinValue)
            {
                    MessageBox.Show("Kaikkia tietoja ei ole täytetty. (Lainaajan nimi, opettajan nimi, päivämäärä).", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
            }

            string studentName = lainaajanNimi_textBox.Text;
            string teacherName = opettajanNimi_textBox.Text;
            DateTime dateTime = varaus_dateTimePicker.Value;
            string additionalInfo = varausMuutaTietoa_textBox.Text;

            if (varaaTyokalut_listbox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Valitse ainakin yksi työkalu", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            List<string> checkedTools = new List<string>();
            foreach (var checkedItem in varaaTyokalut_listbox.CheckedItems)
            {
                checkedTools.Add(checkedItem.ToString());
            }

            _borrowingInfo.SendBookingInfo(studentName, teacherName, dateTime, additionalInfo, checkedTools);
            //aktiivisetVarauksetListBox.Items.Add(studentName); Varaussivu / Ei käytössä
            palautusListbox.Items.Add(studentName);


            ClearFields();

            MessageBox.Show("Lainaus hyväksytty. Voit tarkastella lainauksia palautussivulla.", "Onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void UpdateOngoingBookingListBox()
        {
            var filter = Builders<BsonDocument>.Filter.Empty;
            var show = Builders<BsonDocument>.Projection.Include("studentName");

            var names = _activeBookings.Find(filter).Project(show).ToList();

            foreach (var name in names)
            {
                string displayName = name.GetValue("studentName").AsString;
                //aktiivisetVarauksetListBox.Items.Add(displayName); // Varaussivu // Ei käytössä
                palautusListbox.Items.Add(displayName);
            }


        }

        private void ClearFields()
        {
            lainaajanNimi_textBox.Text = "";
            opettajanNimi_textBox.Text = "";
            varaus_dateTimePicker.Value = DateTime.Now;
            varausMuutaTietoa_textBox.Text = "";

            foreach (int index in varaaTyokalut_listbox.CheckedIndices)
            {
                varaaTyokalut_listbox.SetItemChecked(index, true);
            }
        }

        private void varaaTyokalut_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void palautusListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStudentName = palautusListbox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStudentName))
            {
                BsonDocument bookingDetails = _borrowingInfo.GetBookingDetails(selectedStudentName);
                if (bookingDetails != null)
                {
                    palautusTyokalutListbox.Items.Clear();
                    palautusTiedotTextBox.Clear();

                    var toolsBorrowed = bookingDetails["checkedTools"].AsBsonArray.Select(x => x.AsString);

                    foreach (var tool in toolsBorrowed)
                    {
                        palautusTyokalutListbox.Items.Add(tool);
                        TickCheckedListBox();
                    }


                    string teacherName = bookingDetails["teacherName"].AsString;
                    string studentName = bookingDetails["studentName"].AsString;
                    string date = bookingDetails["dateTime"].ToUniversalTime().ToString("dd-MM-yyyy");
                    string additionalInfo = bookingDetails["additionalInfo"].AsString;

                    string fullInfo = $"Opettajan nimi: {teacherName}\r\n" +
                                      $"Lainaajan nimi: {studentName}\r\n" +
                                      $"Päiväys: {date}\r\n" +
                                      $"Muuta tietoa: {additionalInfo}";

                    palautusTiedotTextBox.Text = fullInfo;


                }
                else
                {
                    palautusTyokalutListbox.Items.Clear();
                    palautusTiedotTextBox.Clear();

                    MessageBox.Show("Valitulle nimikkeelle ei löydy tietoja.");
                }
            }


        }

        private void palautaButton_Click(object sender, EventArgs e)
        {
            _returnInfo.palautusButton_Click(sender, e);
        }

        

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterListBoxItems(textBoxSearch.Text);

        }

        private void FilterListBoxItems(string searchText)
        {
            var bookingNames = _borrowingInfo.GetBookingName();
            palautusListbox.Items.Clear();

            foreach (var name in bookingNames)
            {

                if (name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    palautusListbox.Items.Add(name);
                }
            }
        }

        private void varastoListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (varastoListbox.SelectedItem != null)
            {
                string selectedTool = varastoListbox.SelectedItem.ToString();
                decimal replacementCost = _toolsInfo.GetToolReplacementCost(selectedTool);
                replacementValueTextBox.Text = $"Korvaushinta: €{replacementCost:N2}";
            }
        }

        private void poistaTyokaluButton_Click(object sender, EventArgs e)
        {
            if (varastoListbox.SelectedItem != null)
            {
                string selectedTool = varastoListbox.SelectedItem.ToString();
                
                DialogResult result = MessageBox.Show($"Haluatko varmasti poistaa työkalun: {selectedTool}?", "Varmista poistaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _toolsInfo.RemoveTool(selectedTool);
                    RefreshListBoxes(); 
                     
                    MessageBox.Show($"{selectedTool} on poistettu käytöstä.", "Työkalu poistettu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("valitse poistettava työkalu.", "Ei valintaa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void lisaaTyokaluButton_Click(object sender, EventArgs e)
        {
            string toolName = tyokaluNimiText.Text;
            if (!decimal.TryParse(tyokaluKorvausText.Text, out decimal replacementCost))
            {
                MessageBox.Show("Syöttämäsi tiedot eivät kelpaa.");
                return;
            }

            _toolsInfo.AddTool(toolName, replacementCost);

            RefreshListBoxes();
            
            tyokaluNimiText.Clear();
            tyokaluKorvausText.Clear();
        }

        private void PopulateToolsList()
        {
            varastoListbox.Items.Clear();
            var tools = _toolsInfo.GetAllTools();
            foreach (var tool in tools)
            {
                varastoListbox.Items.Add(tool);
                //varaaTyokalut_listbox.Items.Add(tool);
            }
        }

        private void RefreshListBoxes()
        {
            
            varastoListbox.Items.Clear();
            var tools = _toolsInfo.GetAllTools();  
            foreach (var tool in tools)
            {
                varastoListbox.Items.Add(tool);
            }

            
            varaaTyokalut_listbox.Items.Clear();
            foreach (var tool in tools)
            {
                varaaTyokalut_listbox.Items.Add(tool, CheckState.Checked);  
            }
        }
        

    }
}
