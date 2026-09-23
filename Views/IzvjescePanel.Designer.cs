namespace Breza.Views
{
    partial class IzvjescePanel
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
            labelPreostalo = new Label();
            btnNext = new Button();
            textBoxNapomena = new TextBox();
            label1 = new Label();
            labelVrijeme = new Label();
            dateTimePicker1 = new DateTimePicker();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPreostalo);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(textBoxNapomena);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelVrijeme);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(29, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1522, 1125);
            panel1.TabIndex = 0;
            // 
            // labelPreostalo
            // 
            labelPreostalo.AutoSize = true;
            labelPreostalo.Location = new Point(1326, 978);
            labelPreostalo.Name = "labelPreostalo";
            labelPreostalo.Size = new Size(138, 25);
            labelPreostalo.TabIndex = 4;
            labelPreostalo.Text = "Preostalo 50/50";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1352, 1058);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 5;
            btnNext.Text = "Dalje";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += buttonDalje_Click;
            // 
            // textBoxNapomena
            // 
            textBoxNapomena.Location = new Point(82, 244);
            textBoxNapomena.Multiline = true;
            textBoxNapomena.Name = "textBoxNapomena";
            textBoxNapomena.Size = new Size(1382, 712);
            textBoxNapomena.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 204);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 2;
            label1.Text = "Napomena o danu:";
            // 
            // labelVrijeme
            // 
            labelVrijeme.AutoSize = true;
            labelVrijeme.Location = new Point(582, 91);
            labelVrijeme.Name = "labelVrijeme";
            labelVrijeme.Size = new Size(70, 25);
            labelVrijeme.TabIndex = 1;
            labelVrijeme.Text = "Datum:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(667, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(3, 20);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(300, 150);
            contentPanel.TabIndex = 6;
            // 
            // IzvjescePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(contentPanel);
            Name = "IzvjescePanel";
            Size = new Size(1582, 1195);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelVrijeme;
        private DateTimePicker dateTimePicker1;
        private Button btnNext;
        private Label labelPreostalo;
        private TextBox textBoxNapomena;
        private Panel contentPanel;
    }
}
