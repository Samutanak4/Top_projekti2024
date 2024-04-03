namespace Työkalupakkisovellus
{
    public partial class Form1 : Form
    {
        private List<VarausTiedotTab> ongoingBorrowings = new List<VarausTiedotTab>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void lahetaVaraus_btn_Click(object sender, EventArgs e)
        {
            List<string> selectedTools = GetSelectedTools();

            VarausTiedotTab newBorrowing = new VarausTiedotTab();
            {
                //Tools
            }
        }

        private List<string> GetSelectedTools()
        {
            List<string> selectedTools = new List<string>();

            foreach (var item in varaaTyokalut_listbox.CheckedItems)
            {
                selectedTools.Add(item.ToString());
            }
            return selectedTools;
        }

        private void UpdateOngoingBorrowListBox()
        {
            aktiivisetVarauksetListBox.Items.Clear();
            foreach (var borrowing in ongoingBorrowings)
            {
                aktiivisetVarauksetListBox.Items.Add($"Student: {borrowing.StudentName}");
            }
        }

        private void ClearFields()
        {
            varaaTyokalut_listbox.ClearSelected();
            opettajanNimi_textBox.Clear();
            lainaajanNimi_textBox.Clear();
            varausMuutaTietoa_textBox.Clear();
        }
    }
}
