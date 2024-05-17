namespace Työkalupakkisovellus
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>§
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tyokaluListaTabPage = new TabPage();
            button1 = new Button();
            label13 = new Label();
            label12 = new Label();
            tyokaluKorvausText = new TextBox();
            tyokaluNimiText = new TextBox();
            label9 = new Label();
            replacementValueTextBox = new TextBox();
            label8 = new Label();
            poistaTyokaluButton = new Button();
            lisaaTyokaluButton = new Button();
            varastoListbox = new ListBox();
            palautusTabPage = new TabPage();
            label5 = new Label();
            textBoxSearch = new TextBox();
            korvaushintaLabel = new Label();
            label11 = new Label();
            label10 = new Label();
            palautusTiedotTextBox = new TextBox();
            palautusListbox = new ListBox();
            palautusTyokalutListbox = new CheckedListBox();
            palautaButton = new Button();
            label7 = new Label();
            varausTabPage = new TabPage();
            palautus_dateTimePicker = new DateTimePicker();
            label14 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            varausMuutaTietoa_textBox = new TextBox();
            lainaajanNimi_textBox = new TextBox();
            opettajanNimi_textBox = new TextBox();
            label3 = new Label();
            varaus_dateTimePicker = new DateTimePicker();
            label2 = new Label();
            lahetaVaraus_btn = new Button();
            varaaTyokalut_listbox = new CheckedListBox();
            tabControl = new TabControl();
            tunnus_textBox = new TextBox();
            label15 = new Label();
            tyokaluListaTabPage.SuspendLayout();
            palautusTabPage.SuspendLayout();
            varausTabPage.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tyokaluListaTabPage
            // 
            tyokaluListaTabPage.BackColor = Color.Gainsboro;
            tyokaluListaTabPage.BorderStyle = BorderStyle.FixedSingle;
            tyokaluListaTabPage.Controls.Add(button1);
            tyokaluListaTabPage.Controls.Add(label13);
            tyokaluListaTabPage.Controls.Add(label12);
            tyokaluListaTabPage.Controls.Add(tyokaluKorvausText);
            tyokaluListaTabPage.Controls.Add(tyokaluNimiText);
            tyokaluListaTabPage.Controls.Add(label9);
            tyokaluListaTabPage.Controls.Add(replacementValueTextBox);
            tyokaluListaTabPage.Controls.Add(label8);
            tyokaluListaTabPage.Controls.Add(poistaTyokaluButton);
            tyokaluListaTabPage.Controls.Add(lisaaTyokaluButton);
            tyokaluListaTabPage.Controls.Add(varastoListbox);
            tyokaluListaTabPage.ForeColor = SystemColors.ControlText;
            tyokaluListaTabPage.Location = new Point(4, 37);
            tyokaluListaTabPage.Name = "tyokaluListaTabPage";
            tyokaluListaTabPage.Padding = new Padding(3);
            tyokaluListaTabPage.Size = new Size(1894, 992);
            tyokaluListaTabPage.TabIndex = 2;
            tyokaluListaTabPage.Text = "Työkalulista";
            // 
            // button1
            // 
            button1.Location = new Point(680, 76);
            button1.Name = "button1";
            button1.Size = new Size(244, 41);
            button1.TabIndex = 10;
            button1.Text = "Muokkaa";
            button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(387, 242);
            label13.Name = "label13";
            label13.Size = new Size(192, 25);
            label13.TabIndex = 9;
            label13.Text = "Työkalun korvaushinta:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(387, 168);
            label12.Name = "label12";
            label12.Size = new Size(125, 25);
            label12.TabIndex = 8;
            label12.Text = "Työkalun nimi:";
            // 
            // tyokaluKorvausText
            // 
            tyokaluKorvausText.Location = new Point(396, 270);
            tyokaluKorvausText.Name = "tyokaluKorvausText";
            tyokaluKorvausText.Size = new Size(244, 31);
            tyokaluKorvausText.TabIndex = 7;
            // 
            // tyokaluNimiText
            // 
            tyokaluNimiText.Location = new Point(396, 196);
            tyokaluNimiText.Name = "tyokaluNimiText";
            tyokaluNimiText.Size = new Size(244, 31);
            tyokaluNimiText.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(387, 143);
            label9.Name = "label9";
            label9.Size = new Size(219, 25);
            label9.TabIndex = 5;
            label9.Text = "Lisättävän työkalun tiedot:";
            // 
            // replacementValueTextBox
            // 
            replacementValueTextBox.Enabled = false;
            replacementValueTextBox.Location = new Point(396, 33);
            replacementValueTextBox.Multiline = true;
            replacementValueTextBox.Name = "replacementValueTextBox";
            replacementValueTextBox.ReadOnly = true;
            replacementValueTextBox.Size = new Size(244, 84);
            replacementValueTextBox.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 5);
            label8.Name = "label8";
            label8.Size = new Size(222, 25);
            label8.TabIndex = 3;
            label8.Text = "Varastossa olevat työkalut:";
            // 
            // poistaTyokaluButton
            // 
            poistaTyokaluButton.Location = new Point(396, 426);
            poistaTyokaluButton.Name = "poistaTyokaluButton";
            poistaTyokaluButton.Size = new Size(244, 76);
            poistaTyokaluButton.TabIndex = 2;
            poistaTyokaluButton.Text = "Poista työkalu -";
            poistaTyokaluButton.UseVisualStyleBackColor = true;
            poistaTyokaluButton.Click += poistaTyokaluButton_Click;
            // 
            // lisaaTyokaluButton
            // 
            lisaaTyokaluButton.Location = new Point(396, 321);
            lisaaTyokaluButton.Name = "lisaaTyokaluButton";
            lisaaTyokaluButton.Size = new Size(244, 76);
            lisaaTyokaluButton.TabIndex = 1;
            lisaaTyokaluButton.Text = "Lisää työkalu +";
            lisaaTyokaluButton.UseVisualStyleBackColor = true;
            lisaaTyokaluButton.Click += lisaaTyokaluButton_Click;
            // 
            // varastoListbox
            // 
            varastoListbox.FormattingEnabled = true;
            varastoListbox.HorizontalScrollbar = true;
            varastoListbox.ItemHeight = 25;
            varastoListbox.Location = new Point(8, 33);
            varastoListbox.Name = "varastoListbox";
            varastoListbox.Size = new Size(364, 904);
            varastoListbox.TabIndex = 0;
            varastoListbox.SelectedIndexChanged += varastoListbox_SelectedIndexChanged;
            // 
            // palautusTabPage
            // 
            palautusTabPage.BackColor = Color.Gainsboro;
            palautusTabPage.BorderStyle = BorderStyle.FixedSingle;
            palautusTabPage.Controls.Add(label5);
            palautusTabPage.Controls.Add(textBoxSearch);
            palautusTabPage.Controls.Add(korvaushintaLabel);
            palautusTabPage.Controls.Add(label11);
            palautusTabPage.Controls.Add(label10);
            palautusTabPage.Controls.Add(palautusTiedotTextBox);
            palautusTabPage.Controls.Add(palautusListbox);
            palautusTabPage.Controls.Add(palautusTyokalutListbox);
            palautusTabPage.Controls.Add(palautaButton);
            palautusTabPage.Controls.Add(label7);
            palautusTabPage.Location = new Point(4, 37);
            palautusTabPage.Name = "palautusTabPage";
            palautusTabPage.Padding = new Padding(3);
            palautusTabPage.Size = new Size(1894, 992);
            palautusTabPage.TabIndex = 1;
            palautusTabPage.Text = "Palautus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 9);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 10;
            label5.Text = "Hae lainausta nimellä:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(9, 37);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(350, 31);
            textBoxSearch.TabIndex = 9;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // korvaushintaLabel
            // 
            korvaushintaLabel.ForeColor = Color.Red;
            korvaushintaLabel.Location = new Point(1005, 673);
            korvaushintaLabel.Name = "korvaushintaLabel";
            korvaushintaLabel.Size = new Size(350, 77);
            korvaushintaLabel.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1005, 84);
            label11.Name = "label11";
            label11.Size = new Size(154, 25);
            label11.TabIndex = 7;
            label11.Text = "Lainauksen tiedot:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(503, 84);
            label10.Name = "label10";
            label10.Size = new Size(147, 25);
            label10.TabIndex = 6;
            label10.Text = "Lainatut työkalut:";
            // 
            // palautusTiedotTextBox
            // 
            palautusTiedotTextBox.Enabled = false;
            palautusTiedotTextBox.Location = new Point(1005, 112);
            palautusTiedotTextBox.Multiline = true;
            palautusTiedotTextBox.Name = "palautusTiedotTextBox";
            palautusTiedotTextBox.ReadOnly = true;
            palautusTiedotTextBox.Size = new Size(350, 544);
            palautusTiedotTextBox.TabIndex = 5;
            // 
            // palautusListbox
            // 
            palautusListbox.FormattingEnabled = true;
            palautusListbox.ItemHeight = 25;
            palautusListbox.Location = new Point(9, 112);
            palautusListbox.Name = "palautusListbox";
            palautusListbox.Size = new Size(350, 804);
            palautusListbox.TabIndex = 4;
            palautusListbox.SelectedIndexChanged += palautusListbox_SelectedIndexChanged;
            // 
            // palautusTyokalutListbox
            // 
            palautusTyokalutListbox.FormattingEnabled = true;
            palautusTyokalutListbox.Location = new Point(503, 112);
            palautusTyokalutListbox.Name = "palautusTyokalutListbox";
            palautusTyokalutListbox.Size = new Size(350, 810);
            palautusTyokalutListbox.TabIndex = 3;
            // 
            // palautaButton
            // 
            palautaButton.Location = new Point(1005, 795);
            palautaButton.Name = "palautaButton";
            palautaButton.Size = new Size(350, 121);
            palautaButton.TabIndex = 2;
            palautaButton.Text = "PALAUTA";
            palautaButton.UseVisualStyleBackColor = true;
            palautaButton.Click += palautaButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 84);
            label7.Name = "label7";
            label7.Size = new Size(227, 25);
            label7.TabIndex = 1;
            label7.Text = "Valitse palautettava lainaus:";
            // 
            // varausTabPage
            // 
            varausTabPage.BackColor = Color.Gainsboro;
            varausTabPage.BorderStyle = BorderStyle.FixedSingle;
            varausTabPage.Controls.Add(label15);
            varausTabPage.Controls.Add(tunnus_textBox);
            varausTabPage.Controls.Add(palautus_dateTimePicker);
            varausTabPage.Controls.Add(label14);
            varausTabPage.Controls.Add(label1);
            varausTabPage.Controls.Add(label6);
            varausTabPage.Controls.Add(label4);
            varausTabPage.Controls.Add(varausMuutaTietoa_textBox);
            varausTabPage.Controls.Add(lainaajanNimi_textBox);
            varausTabPage.Controls.Add(opettajanNimi_textBox);
            varausTabPage.Controls.Add(label3);
            varausTabPage.Controls.Add(varaus_dateTimePicker);
            varausTabPage.Controls.Add(label2);
            varausTabPage.Controls.Add(lahetaVaraus_btn);
            varausTabPage.Controls.Add(varaaTyokalut_listbox);
            varausTabPage.Location = new Point(4, 37);
            varausTabPage.Name = "varausTabPage";
            varausTabPage.Padding = new Padding(3);
            varausTabPage.Size = new Size(1894, 992);
            varausTabPage.TabIndex = 0;
            varausTabPage.Text = "Varaus";
            // 
            // palautus_dateTimePicker
            // 
            palautus_dateTimePicker.Location = new Point(385, 337);
            palautus_dateTimePicker.Name = "palautus_dateTimePicker";
            palautus_dateTimePicker.Size = new Size(340, 31);
            palautus_dateTimePicker.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(380, 309);
            label14.Name = "label14";
            label14.Size = new Size(252, 25);
            label14.TabIndex = 12;
            label14.Text = "Odotettu palautuspäivämäärä:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(380, 31);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 5;
            label1.Text = "Lainaajan nimi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 31);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 11;
            label6.Text = "Valitse Työkalut:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(385, 371);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 10;
            label4.Text = "Muuta tietoa: ";
            // 
            // varausMuutaTietoa_textBox
            // 
            varausMuutaTietoa_textBox.BorderStyle = BorderStyle.FixedSingle;
            varausMuutaTietoa_textBox.Location = new Point(385, 399);
            varausMuutaTietoa_textBox.Multiline = true;
            varausMuutaTietoa_textBox.Name = "varausMuutaTietoa_textBox";
            varausMuutaTietoa_textBox.Size = new Size(340, 416);
            varausMuutaTietoa_textBox.TabIndex = 9;
            // 
            // lainaajanNimi_textBox
            // 
            lainaajanNimi_textBox.Location = new Point(385, 59);
            lainaajanNimi_textBox.Name = "lainaajanNimi_textBox";
            lainaajanNimi_textBox.Size = new Size(340, 31);
            lainaajanNimi_textBox.TabIndex = 4;
            // 
            // opettajanNimi_textBox
            // 
            opettajanNimi_textBox.Location = new Point(385, 203);
            opettajanNimi_textBox.Name = "opettajanNimi_textBox";
            opettajanNimi_textBox.Size = new Size(340, 31);
            opettajanNimi_textBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(380, 247);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 8;
            label3.Text = "Päivämäärä:";
            // 
            // varaus_dateTimePicker
            // 
            varaus_dateTimePicker.Location = new Point(385, 275);
            varaus_dateTimePicker.Name = "varaus_dateTimePicker";
            varaus_dateTimePicker.Size = new Size(340, 31);
            varaus_dateTimePicker.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(380, 175);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 6;
            label2.Text = "Opettajan nimi:";
            // 
            // lahetaVaraus_btn
            // 
            lahetaVaraus_btn.Location = new Point(385, 839);
            lahetaVaraus_btn.Name = "lahetaVaraus_btn";
            lahetaVaraus_btn.Size = new Size(340, 108);
            lahetaVaraus_btn.TabIndex = 1;
            lahetaVaraus_btn.Text = "LÄHETÄ";
            lahetaVaraus_btn.UseVisualStyleBackColor = true;
            lahetaVaraus_btn.Click += lahetaVaraus_btn_Click;
            // 
            // varaaTyokalut_listbox
            // 
            varaaTyokalut_listbox.CheckOnClick = true;
            varaaTyokalut_listbox.FormattingEnabled = true;
            varaaTyokalut_listbox.HorizontalScrollbar = true;
            varaaTyokalut_listbox.Location = new Point(3, 59);
            varaaTyokalut_listbox.Name = "varaaTyokalut_listbox";
            varaaTyokalut_listbox.Size = new Size(335, 888);
            varaaTyokalut_listbox.TabIndex = 0;
            varaaTyokalut_listbox.SelectedIndexChanged += varaaTyokalut_listbox_SelectedIndexChanged;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.Controls.Add(varausTabPage);
            tabControl.Controls.Add(palautusTabPage);
            tabControl.Controls.Add(tyokaluListaTabPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1902, 1033);
            tabControl.TabIndex = 0;
            // 
            // tunnus_textBox
            // 
            tunnus_textBox.Location = new Point(385, 131);
            tunnus_textBox.Name = "tunnus_textBox";
            tunnus_textBox.Size = new Size(340, 31);
            tunnus_textBox.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(380, 103);
            label15.Name = "label15";
            label15.Size = new Size(125, 25);
            label15.TabIndex = 15;
            label15.Text = "Ryhmätunnus:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);

            MinimumSize = new Size(932, 647);
            Name = "Form1";

            Name = "FormMain";

            Text = "Työkalujen hallintasovellus";
            Load += Form1_Load;
            tyokaluListaTabPage.ResumeLayout(false);
            tyokaluListaTabPage.PerformLayout();
            palautusTabPage.ResumeLayout(false);
            palautusTabPage.PerformLayout();
            varausTabPage.ResumeLayout(false);
            varausTabPage.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TabPage Varaushistoria;
        private CheckedListBox checkedListBox1;
        private TextBox tyokaluKorvausText;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TabPage tyokaluListaTabPage;
        private Label label8;
        private Button poistaTyokaluButton;
        private Button lisaaTyokaluButton;
        private ListBox varastoListbox;
        private TabPage palautusTabPage;
        private Label label11;
        private Label label10;
        private TextBox palautusTiedotTextBox;
        private CheckedListBox palautusTyokalutListbox;
        private Button palautaButton;
        private Label label7;
        private TabPage varausTabPage;
        private Label label6;
        private Label label4;
        private TextBox varausMuutaTietoa_textBox;
        private TextBox lainaajanNimi_textBox;
        private TextBox opettajanNimi_textBox;
        private Label label3;
        private DateTimePicker varaus_dateTimePicker;
        private Label label2;
        private Label label1;
        private Button lahetaVaraus_btn;
        private CheckedListBox varaaTyokalut_listbox;
        private TabControl tabControl;
        private Label korvaushintaLabel;
        public ListBox palautusListbox;
        private Label label5;
        private TextBox textBoxSearch;
        private TextBox replacementValueTextBox;
        private Label label9;
        private Label label13;
        private Label label12;
        private TextBox tyokaluNimiText;
        private Button button1;
        private DateTimePicker palautus_dateTimePicker;
        private Label label14;
        private Label label15;
        private TextBox tunnus_textBox;
    }
}
