
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

            _borrowingInfo = new VarausTiedotTab();
            _returnInfo = new PalautusTab(palautusTyokalutListbox, korvaushintaLabel, palautaButton, palautusListbox, _borrowingInfo);
            
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
            string studentName = lainaajanNimi_textBox.Text;
            string teacherName = opettajanNimi_textBox.Text;
            DateTime dateTime = varaus_dateTimePicker.Value;
            string additionalInfo = varausMuutaTietoa_textBox.Text;

            List<string> checkedTools = new List<string>();
            foreach (var checkedItem in varaaTyokalut_listbox.CheckedItems)
            {
                checkedTools.Add(checkedItem.ToString());
            }

            _borrowingInfo.SendBookingInfo(studentName, teacherName, dateTime, additionalInfo, checkedTools);
            //aktiivisetVarauksetListBox.Items.Add(studentName); Varaussivu / Ei käytössä
            palautusListbox.Items.Add(studentName);


            ClearFields();
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
                varaaTyokalut_listbox.SetItemChecked(index, false);
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

        private void lisaaTyokaluButton_Click(object sender, EventArgs e)
        {

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
                string selectedToolName = varastoListbox.SelectedItem.ToString();
                decimal replacementCost = _toolsInfo.GetToolReplacementCost(selectedToolName);
                replacementValueTextBox.Text = "Valitun työkalun korvaushinta: " + replacementCost.ToString("C2");  
            }
        }
    }
}
