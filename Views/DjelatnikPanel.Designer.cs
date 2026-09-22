namespace Breza.Views
{
    partial class DjelatnikPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBoxPrezime = new TextBox();
            label1 = new Label();
            comboBoxOvlasti = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBoxIme = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPrezime);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxOvlasti);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxIme);
            panel1.Location = new Point(123, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 462);
            panel1.TabIndex = 0;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(247, 172);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(301, 31);
            textBoxPrezime.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 229);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(123, 25);
            label1.TabIndex = 11;
            label1.Text = ":Razina ovlasti";
            // 
            // comboBoxOvlasti
            // 
            comboBoxOvlasti.FormattingEnabled = true;
            comboBoxOvlasti.Location = new Point(292, 226);
            comboBoxOvlasti.Name = "comboBoxOvlasti";
            comboBoxOvlasti.Size = new Size(256, 33);
            comboBoxOvlasti.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 175);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 8;
            label4.Text = "Prezime:";
            // 
            // button1
            // 
            button1.Location = new Point(436, 302);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 127);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 6;
            label3.Text = "Ime:";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(235, 127);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(313, 31);
            textBoxIme.TabIndex = 5;
            // 
            // DjelatnikPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "DjelatnikPanel";
            Size = new Size(1143, 940);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxOvlasti;
        private Label label4;
        private Button button1;
        private Label label3;
        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
    }
}
