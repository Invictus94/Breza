using Breza.Helpers;
using Microsoft.VisualBasic.Devices;
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
        IDatabase database = Core.Database;
        public Prijava()
        {
            InitializeComponent();

            AcceptButton = buttonPrijava;

            if (Core.NOLOGIN_MODE)
            {
                buttonPrijava_Click(null, null);
            }
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            var ok = Core.NOLOGIN_MODE;
            var user = new Models.Djelatnik()
            {
                Ime = "Admin",
                Prezime = textBoxLozinka.Text,
                Ovlasti = Models.UserRole.Admin
            };

            if (!ok)
            {
                var djelatnik = database.Prijava(textBoxKorIme.Text, textBoxLozinka.Text);
                ok = djelatnik != null;
                user = djelatnik;
            }

            if (ok)
            {
                Core.CurrentUser = user;
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

        private void textBoxKorIme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                buttonPrijava_Click(null, null);
            }
        }
    }
}
