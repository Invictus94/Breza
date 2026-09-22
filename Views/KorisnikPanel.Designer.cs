namespace Breza.Views
{
    partial class KorisnikPanel
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
            label1 = new Label();
            label2 = new Label();
            textBoxIme = new TextBox();
            button1 = new Button();
            textBoxPrezime = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 1;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 133);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Prezime:";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(112, 85);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(313, 31);
            textBoxIme.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(313, 199);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(124, 130);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(301, 31);
            textBoxPrezime.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxPrezime);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxIme);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 335);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 133);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 85);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 1;
            label3.Text = "Ime:";
            // 
            // KorisnikPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "KorisnikPanel";
            Size = new Size(1373, 865);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIme;
        private Button button1;
        private TextBox textBoxPrezime;
        private Panel panel1;
        private Label label4;
        private Label label3;
    }
}
