
using System.Windows.Forms;

namespace Työkalupakkisovellus
{
    public partial class Form1 : Form
    {

        private VarausTiedotTab _borrowingInfo;
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

            _borrowingInfo = new VarausTiedotTab();
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
            
            ClearFields();
        }



        private void UpdateOngoingBorrowListBox()
        {
           
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
    }
}
