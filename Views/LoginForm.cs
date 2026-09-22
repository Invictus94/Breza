using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Breza.Views
{
    public partial class Prijava : Form
    {
        private const string CorrectPassword = "1234";
        public Prijava()
        {
            InitializeComponent();

            AcceptButton = buttonPrijava;
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text == CorrectPassword)
            {
                Hide();

                using (var mainForm = new Form1())
                {
                    mainForm.ShowDialog();
                }

                Close();
            }
            else
            {
                MessageBox.Show(
                    "Pogrešno ime ili lozinka!",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxLozinka.Clear();
                textBoxKorIme.Focus();
            }
        }
    }
}
