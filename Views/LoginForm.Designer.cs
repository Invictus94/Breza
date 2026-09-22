namespace Breza.Views
{
    partial class Prijava
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxLozinka = new TextBox();
            textBoxKorIme = new TextBox();
            buttonPrijava = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 255);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 302);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Lozinka:";
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.Location = new Point(267, 299);
            textBoxLozinka.Name = "textBoxLozinka";
            textBoxLozinka.Size = new Size(299, 31);
            textBoxLozinka.TabIndex = 2;
            textBoxLozinka.Text = "1234";
            textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // textBoxKorIme
            // 
            textBoxKorIme.Location = new Point(267, 255);
            textBoxKorIme.Name = "textBoxKorIme";
            textBoxKorIme.Size = new Size(299, 31);
            textBoxKorIme.TabIndex = 3;
            // 
            // buttonPrijava
            // 
            buttonPrijava.Location = new Point(344, 382);
            buttonPrijava.Name = "buttonPrijava";
            buttonPrijava.Size = new Size(112, 34);
            buttonPrijava.TabIndex = 4;
            buttonPrijava.Text = "Prijava";
            buttonPrijava.UseVisualStyleBackColor = true;
            buttonPrijava.Click += buttonPrijava_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(233, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Prijava
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonPrijava);
            Controls.Add(textBoxKorIme);
            Controls.Add(textBoxLozinka);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Prijava";
            Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLozinka;
        private TextBox textBoxKorIme;
        private Button buttonPrijava;
        private PictureBox pictureBox1;
    }
}