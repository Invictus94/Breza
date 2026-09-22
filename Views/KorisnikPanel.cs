using Breza.Helpers;
using Breza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Breza.Views
{
    public partial class KorisnikPanel : UserControl
    {
        IDatabase database = Core.Database;
        Korisnik korisnik = new Korisnik();
        public KorisnikPanel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            textBoxIme.DataBindings.Add(
                "Text",
                korisnik,
                nameof(Korisnik.Ime),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            textBoxPrezime.DataBindings.Add(
                "Text",
                korisnik,
                nameof(Korisnik.Prezime),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void CenterPanel()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterPanel();
        }

private async void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Dodati korisnika:\n\n{korisnik.Ime} {korisnik.Prezime}?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var ok = database.DodajKorisnika(
                    korisnik);

                if (ok)
                {
                    MessageBox.Show(
                        $"Korisnik {textBoxIme.Text} {textBoxPrezime.Text} je uspješno dodan.",
                        "Uspješno",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    korisnik.Id = Core.GetNewID;
                }
                else
                {
                    MessageBox.Show(
                        $"Korisnik {textBoxIme.Text} {textBoxPrezime.Text} nije dodan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    }
}
