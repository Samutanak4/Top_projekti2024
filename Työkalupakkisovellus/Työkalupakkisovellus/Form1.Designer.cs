namespace Työkalupakkisovellus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            label4 = new Label();
            varausMuutaTietoa_textBox = new TextBox();
            label3 = new Label();
            varaus_dateTimePicker = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            lainaajanNimi_textBox = new TextBox();
            opettajanNimi_textBox = new TextBox();
            lahetaVaraus_btn = new Button();
            varaaTyokalut_listbox = new CheckedListBox();
            tabPage2 = new TabPage();
            palautusListbox = new ListBox();
            palautusTyokalutListbox = new CheckedListBox();
            button4 = new Button();
            label7 = new Label();
            tabPage3 = new TabPage();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            varastoListbox = new ListBox();
            tabPage4 = new TabPage();
            textBox1 = new TextBox();
            label9 = new Label();
            button3 = new Button();
            aktiivisetVarauksetListBox = new ListBox();
            label5 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.Buttons;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(1, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(914, 600);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gainsboro;
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(varausMuutaTietoa_textBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(varaus_dateTimePicker);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lainaajanNimi_textBox);
            tabPage1.Controls.Add(opettajanNimi_textBox);
            tabPage1.Controls.Add(lahetaVaraus_btn);
            tabPage1.Controls.Add(varaaTyokalut_listbox);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 559);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Varaus";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 6);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 11;
            label6.Text = "Valitse Työkalut:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 216);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 10;
            label4.Text = "Muuta tietoa: ";
            // 
            // varausMuutaTietoa_textBox
            // 
            varausMuutaTietoa_textBox.BorderStyle = BorderStyle.FixedSingle;
            varausMuutaTietoa_textBox.Location = new Point(224, 244);
            varausMuutaTietoa_textBox.Multiline = true;
            varausMuutaTietoa_textBox.Name = "varausMuutaTietoa_textBox";
            varausMuutaTietoa_textBox.Size = new Size(313, 288);
            varausMuutaTietoa_textBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 140);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 8;
            label3.Text = "Päivämäärä:";
            // 
            // varaus_dateTimePicker
            // 
            varaus_dateTimePicker.Location = new Point(224, 168);
            varaus_dateTimePicker.Name = "varaus_dateTimePicker";
            varaus_dateTimePicker.Size = new Size(313, 31);
            varaus_dateTimePicker.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 68);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 6;
            label2.Text = "Opettajan nimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 3);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 5;
            label1.Text = "Lainaajan nimi:";
            // 
            // lainaajanNimi_textBox
            // 
            lainaajanNimi_textBox.Location = new Point(224, 34);
            lainaajanNimi_textBox.Name = "lainaajanNimi_textBox";
            lainaajanNimi_textBox.Size = new Size(313, 31);
            lainaajanNimi_textBox.TabIndex = 4;
            // 
            // opettajanNimi_textBox
            // 
            opettajanNimi_textBox.Location = new Point(224, 96);
            opettajanNimi_textBox.Name = "opettajanNimi_textBox";
            opettajanNimi_textBox.Size = new Size(313, 31);
            opettajanNimi_textBox.TabIndex = 3;
            // 
            // lahetaVaraus_btn
            // 
            lahetaVaraus_btn.Location = new Point(643, 474);
            lahetaVaraus_btn.Name = "lahetaVaraus_btn";
            lahetaVaraus_btn.Size = new Size(211, 58);
            lahetaVaraus_btn.TabIndex = 1;
            lahetaVaraus_btn.Text = "LÄHETÄ";
            lahetaVaraus_btn.UseVisualStyleBackColor = true;
            lahetaVaraus_btn.Click += lahetaVaraus_btn_Click;
            // 
            // varaaTyokalut_listbox
            // 
            varaaTyokalut_listbox.FormattingEnabled = true;
            varaaTyokalut_listbox.HorizontalScrollbar = true;
            varaaTyokalut_listbox.Location = new Point(8, 34);
            varaaTyokalut_listbox.Name = "varaaTyokalut_listbox";
            varaaTyokalut_listbox.Size = new Size(210, 498);
            varaaTyokalut_listbox.TabIndex = 0;
            varaaTyokalut_listbox.SelectedIndexChanged += varaaTyokalut_listbox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gainsboro;
            tabPage2.Controls.Add(palautusListbox);
            tabPage2.Controls.Add(palautusTyokalutListbox);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 559);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Palautus";
            // 
            // palautusListbox
            // 
            palautusListbox.FormattingEnabled = true;
            palautusListbox.ItemHeight = 25;
            palautusListbox.Location = new Point(9, 37);
            palautusListbox.Name = "palautusListbox";
            palautusListbox.Size = new Size(227, 504);
            palautusListbox.TabIndex = 4;
            // 
            // palautusTyokalutListbox
            // 
            palautusTyokalutListbox.FormattingEnabled = true;
            palautusTyokalutListbox.Location = new Point(279, 37);
            palautusTyokalutListbox.Name = "palautusTyokalutListbox";
            palautusTyokalutListbox.Size = new Size(293, 498);
            palautusTyokalutListbox.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(693, 474);
            button4.Name = "button4";
            button4.Size = new Size(174, 61);
            button4.TabIndex = 2;
            button4.Text = "PALAUTA";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 9);
            label7.Name = "label7";
            label7.Size = new Size(227, 25);
            label7.TabIndex = 1;
            label7.Text = "Valitse palautettava lainaus:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gainsboro;
            tabPage3.BorderStyle = BorderStyle.FixedSingle;
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(varastoListbox);
            tabPage3.ForeColor = SystemColors.ControlText;
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(906, 559);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Varasto";
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
            // button1
            // 
            button1.Location = new Point(733, 457);
            button1.Name = "button1";
            button1.Size = new Size(152, 37);
            button1.TabIndex = 2;
            button1.Text = "Poista työkalu -";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(733, 500);
            button2.Name = "button2";
            button2.Size = new Size(152, 37);
            button2.TabIndex = 1;
            button2.Text = "Lisää työkalu +";
            button2.UseVisualStyleBackColor = true;
            // 
            // varastoListbox
            // 
            varastoListbox.FormattingEnabled = true;
            varastoListbox.HorizontalScrollbar = true;
            varastoListbox.ItemHeight = 25;
            varastoListbox.Location = new Point(8, 33);
            varastoListbox.Name = "varastoListbox";
            varastoListbox.Size = new Size(211, 504);
            varastoListbox.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Gainsboro;
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(aktiivisetVarauksetListBox);
            tabPage4.Controls.Add(label5);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(906, 559);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Varaushistoria";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 305);
            textBox1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 8);
            label9.Name = "label9";
            label9.Size = new Size(148, 25);
            label9.TabIndex = 3;
            label9.Text = "Varauksen tiedot:";
            // 
            // button3
            // 
            button3.Location = new Point(667, 486);
            button3.Name = "button3";
            button3.Size = new Size(220, 54);
            button3.TabIndex = 2;
            button3.Text = "Muokkaa varausta";
            button3.UseVisualStyleBackColor = true;
            // 
            // aktiivisetVarauksetListBox
            // 
            aktiivisetVarauksetListBox.FormattingEnabled = true;
            aktiivisetVarauksetListBox.ItemHeight = 25;
            aktiivisetVarauksetListBox.Location = new Point(8, 36);
            aktiivisetVarauksetListBox.Name = "aktiivisetVarauksetListBox";
            aktiivisetVarauksetListBox.Size = new Size(211, 504);
            aktiivisetVarauksetListBox.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 8);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 0;
            label5.Text = "Aktiiviset varaukset:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Työkalujen hallintasovellus";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private TabPage Varaushistoria;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private Button lahetaVaraus_btn;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
        private ListBox varastoListbox;
        private ListBox aktiivisetVarauksetListBox;
        private Label label5;
        private Button button3;
        private CheckedListBox varaaTyokalut_listbox;
        private TextBox varausMuutaTietoa_textBox;
        private DateTimePicker varaus_dateTimePicker;
        private TextBox lainaajanNimi_textBox;
        private TextBox opettajanNimi_textBox;
        private Label label6;
        private Button button4;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckedListBox palautusTyokalutListbox;
        private ListBox palautusListbox;
    }
}
