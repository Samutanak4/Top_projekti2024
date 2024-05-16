using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Työkalupakkisovellus
{
    internal class PalautusTab
    {
        private CheckedListBox _palautusTyokalutListbox;
        private Label _korvaushintaLabel;
        private VarausTiedotTab _borrowingInfo;
        private Button _palautaButton;
        private ListBox _palautusListBox;

        //private VarausTiedotTab _activeBooking;

        public PalautusTab(CheckedListBox checkedToolsListBox, Label replacementCostLabel, Button returnButton, ListBox palautusListBox, VarausTiedotTab borrowingInfo)
        {
             _palautusTyokalutListbox = checkedToolsListBox;
             _korvaushintaLabel = replacementCostLabel;
             _borrowingInfo = borrowingInfo;
             _palautaButton = returnButton;
            _palautusListBox = palautusListBox;

            
            _palautusTyokalutListbox.ItemCheck += CheckedToolsListBox_ItemCheck;
        }

        public void palautusButton_Click(object sender, EventArgs e)
        {
            if (_palautusListBox.SelectedItem == null)
            {
                MessageBox.Show("Valitse palautettava lainaus.", "Ei valintaa.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentName = _palautusListBox.SelectedItem.ToString();
            //BsonDocument bookingDetails = _borrowingInfo.GetBookingDetails(studentName);
            
            decimal replacementCost = CalculateReplacementCosts();
            string costMessage = replacementCost > 0 ? $"\n\nHUOM! kaikkia työkaluja ei valittu. Korvaushinta puuttuville työkaluille: €{replacementCost:N2}." : "";

            string message = $"Haluatko varmasti palauttaa tämän lainauksen?{costMessage}";
            DialogResult result = MessageBox.Show(message, "Hyväksy palautus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _borrowingInfo.RemoveBookingName(studentName);
                _palautusListBox.Items.Remove(_palautusListBox.SelectedItem);
                _palautusTyokalutListbox.Items.Clear();
                _korvaushintaLabel.Text = "";

                MessageBox.Show("Lainaus palautettu onnistuneesti.", "Palautus hyväksytty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private decimal CalculateReplacementCosts()
        {
            decimal totalReplacementCost = 0;
            foreach (string tool in _palautusTyokalutListbox.Items)
            {
                if (!_palautusTyokalutListbox.CheckedItems.Contains(tool))
                {
                    decimal cost = _borrowingInfo.GetToolReplacementCost(tool);
                    totalReplacementCost += cost;
                }
            }
            return totalReplacementCost;
        }


        public void LoadToolsForBooking(string bookingId)
        {
            var tools = _borrowingInfo.GetBorrowedToolsForBooking(bookingId);
            _palautusTyokalutListbox.Items.Clear();
            foreach (var tool in tools)
            {
                _palautusTyokalutListbox.Items.Add(tool, CheckState.Unchecked); 
            }

            
            CalculateAndDisplayReplacementCosts();
        }

        private void CheckedToolsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {           
            _palautusTyokalutListbox.BeginInvoke(new Action(CalculateAndDisplayReplacementCosts));
        }

        private void CalculateAndDisplayReplacementCosts()
        {
            decimal totalReplacementCost = 0;

            foreach (string tool in _palautusTyokalutListbox.Items)
            {
                if (!_palautusTyokalutListbox.CheckedItems.Contains(tool))
                {
                    decimal cost = _borrowingInfo.GetToolReplacementCost(tool);
                    totalReplacementCost += cost;
                }
            }

            _korvaushintaLabel.Text = $"HUOM! Puuttuvien työkalujen korvaushinta: €{totalReplacementCost:N2}";
            _korvaushintaLabel.Visible = totalReplacementCost > 0;
        }

        private void FinalizeReturn()
        {
            
            _palautusTyokalutListbox.Items.Clear();
            _korvaushintaLabel.Text = "";
        }
    }
}
