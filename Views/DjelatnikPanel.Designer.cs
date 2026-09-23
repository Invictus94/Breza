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
            textBoxLozinka = new TextBox();
            label2 = new Label();
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
            panel1.AutoSize = true;
            panel1.Controls.Add(textBoxLozinka);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxPrezime);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxOvlasti);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxIme);
            panel1.Location = new Point(123, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 789);
            panel1.TabIndex = 0;
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.Font = new Font("Segoe UI", 22F);
            textBoxLozinka.Location = new Point(405, 347);
            textBoxLozinka.Name = "textBoxLozinka";
            textBoxLozinka.Size = new Size(450, 66);
            textBoxLozinka.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F);
            label2.Location = new Point(193, 347);
            label2.Name = "label2";
            label2.Size = new Size(182, 60);
            label2.TabIndex = 13;
            label2.Text = "Lozinka:";
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Font = new Font("Segoe UI", 22F);
            textBoxPrezime.Location = new Point(406, 240);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(449, 66);
            textBoxPrezime.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(77, 452);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(298, 60);
            label1.TabIndex = 11;
            label1.Text = ":Razina ovlasti";
            // 
            // comboBoxOvlasti
            // 
            comboBoxOvlasti.Font = new Font("Segoe UI", 22F);
            comboBoxOvlasti.FormattingEnabled = true;
            comboBoxOvlasti.Location = new Point(405, 449);
            comboBoxOvlasti.Name = "comboBoxOvlasti";
            comboBoxOvlasti.Size = new Size(450, 68);
            comboBoxOvlasti.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F);
            label4.Location = new Point(185, 243);
            label4.Name = "label4";
            label4.Size = new Size(190, 60);
            label4.TabIndex = 8;
            label4.Text = "Prezime:";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(391, 578);
            button1.Name = "button1";
            button1.Size = new Size(151, 70);
            button1.TabIndex = 9;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F);
            label3.Location = new Point(267, 144);
            label3.Name = "label3";
            label3.Size = new Size(108, 60);
            label3.TabIndex = 6;
            label3.Text = "Ime:";
            // 
            // textBoxIme
            // 
            textBoxIme.Font = new Font("Segoe UI", 22F);
            textBoxIme.Location = new Point(405, 141);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(450, 66);
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
            PerformLayout();
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
        private Label label2;
        private TextBox textBoxLozinka;
    }
}
