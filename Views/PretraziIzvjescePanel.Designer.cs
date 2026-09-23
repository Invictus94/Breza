namespace Breza.Views
{
    partial class PretraziIzvjescePanel
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
            comboBoxStatusIzvj = new ComboBox();
            comboBoxKorisnik = new ComboBox();
            comboBoxDjelatnik = new ComboBox();
            dateTimePickerOd = new DateTimePicker();
            dateTimePickerDo = new DateTimePicker();
            buttonPretraga = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxStatusIzvj);
            panel1.Controls.Add(comboBoxKorisnik);
            panel1.Controls.Add(comboBoxDjelatnik);
            panel1.Controls.Add(dateTimePickerOd);
            panel1.Controls.Add(dateTimePickerDo);
            panel1.Controls.Add(buttonPretraga);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 528);
            panel1.TabIndex = 0;
            // 
            // comboBoxStatusIzvj
            // 
            comboBoxStatusIzvj.FormattingEnabled = true;
            comboBoxStatusIzvj.Location = new Point(207, 361);
            comboBoxStatusIzvj.Name = "comboBoxStatusIzvj";
            comboBoxStatusIzvj.Size = new Size(296, 33);
            comboBoxStatusIzvj.TabIndex = 11;
            // 
            // comboBoxKorisnik
            // 
            comboBoxKorisnik.FormattingEnabled = true;
            comboBoxKorisnik.Location = new Point(172, 281);
            comboBoxKorisnik.Name = "comboBoxKorisnik";
            comboBoxKorisnik.Size = new Size(331, 33);
            comboBoxKorisnik.TabIndex = 10;
            // 
            // comboBoxDjelatnik
            // 
            comboBoxDjelatnik.FormattingEnabled = true;
            comboBoxDjelatnik.Location = new Point(164, 216);
            comboBoxDjelatnik.Name = "comboBoxDjelatnik";
            comboBoxDjelatnik.Size = new Size(339, 33);
            comboBoxDjelatnik.TabIndex = 9;
            // 
            // dateTimePickerOd
            // 
            dateTimePickerOd.Location = new Point(164, 137);
            dateTimePickerOd.Name = "dateTimePickerOd";
            dateTimePickerOd.ShowCheckBox = true;
            dateTimePickerOd.Size = new Size(300, 31);
            dateTimePickerOd.TabIndex = 8;
            // 
            // dateTimePickerDo
            // 
            dateTimePickerDo.Location = new Point(658, 137);
            dateTimePickerDo.Name = "dateTimePickerDo";
            dateTimePickerDo.ShowCheckBox = true;
            dateTimePickerDo.Size = new Size(300, 31);
            dateTimePickerDo.TabIndex = 7;
            // 
            // buttonPretraga
            // 
            buttonPretraga.Location = new Point(468, 456);
            buttonPretraga.Name = "buttonPretraga";
            buttonPretraga.Size = new Size(112, 34);
            buttonPretraga.TabIndex = 6;
            buttonPretraga.Text = "Pretraži";
            buttonPretraga.UseVisualStyleBackColor = true;
            buttonPretraga.Click += buttonPretraga_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 364);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 5;
            label6.Text = "Status izvješća";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 284);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 4;
            label5.Text = "Korisnik/ca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 219);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "Djelatnik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 142);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "datum do:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 142);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Datum od:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 30);
            label1.Name = "label1";
            label1.Size = new Size(255, 45);
            label1.TabIndex = 0;
            label1.Text = "Pretraga izvješća";
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(13, 22);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(300, 150);
            contentPanel.TabIndex = 1;
            // 
            // PretraziIzvjescePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(contentPanel);
            Name = "PretraziIzvjescePanel";
            Size = new Size(1164, 615);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePickerOd;
        private DateTimePicker dateTimePickerDo;
        private Button buttonPretraga;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxStatusIzvj;
        private ComboBox comboBoxKorisnik;
        private ComboBox comboBoxDjelatnik;
        private Panel contentPanel;
    }
}
