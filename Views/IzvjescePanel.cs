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
    public partial class IzvjescePanel : UserControl
    {
        IDatabase database;
        private int currentStep = 0;
        Korisnik[] korisnici;
        private readonly List<UserControl> steps = new List<UserControl>();
        IzvjesceDnevno dnevno = new IzvjesceDnevno();

        public IzvjescePanel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            contentPanel.Visible = false;

            dohvatiKorisnike();
            steps.Add(new UserControl());

            foreach (var korisnik in korisnici)
            {
                var izvjesceKorisnik = new IzvjesceKorisnik()
                {
                    Korisnik = korisnik,
                };

                dnevno.IzvjesceKorisnika.Add(izvjesceKorisnik);
                steps.Add(new IzvjesceKorisnikPanel(izvjesceKorisnik, () => Back(), () => buttonDalje_Click(null, null)));
            }

            dnevno.Datum = DateTime.Now;
            dnevno.Djelatnik = Core.CurrentUser;

            textBoxNapomena.DataBindings.Add(
            "Text",
            dnevno,
            nameof(IzvjesceDnevno.DnevnaNapomena),
            true,
            DataSourceUpdateMode.OnPropertyChanged);

            dateTimePicker1.DataBindings.Add(
                "Value",
                dnevno,
                nameof(IzvjesceDnevno.Datum),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }
        private void CenterPanel()
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;

            contentPanel.Width = panel1.Width;
            contentPanel.Height = panel1.Height;
            contentPanel.Left = panel1.Left;
            contentPanel.Top = panel1.Top;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterPanel();
        }

        private void dohvatiKorisnike()
        {
            if (Core.TESTING_MODE)
            {
                korisnici = new Korisnik[]
                {
                    new Korisnik { Ime = "Marko", Prezime = "Marković" },
                    new Korisnik { Ime = "Ana", Prezime = "Anić" },
                    new Korisnik { Ime = "Ivan", Prezime = "Ivić" }
                };

            }
            else
            {
                korisnici = database.DohvatiKorisnike();
            }
        }
        private void ShowStep(int step)
        {
            contentPanel.Controls.Clear();

            UserControl page = steps[step];

            page.Dock = DockStyle.Fill;

            contentPanel.Controls.Add(page);
        }

        private void buttonDalje_Click(object sender, EventArgs e)
        {
            contentPanel.Visible = true;
            panel1.Visible = false;

            if (currentStep < steps.Count-1)
            {
                currentStep++;
                ShowStep(currentStep);
            }
            else
            {
                Finish();
            }
        }

        private void Back()
        {
            var actual = currentStep - 1;

            currentStep = Math.Max(0, actual);

            if (currentStep <= 0)
            {
                contentPanel.Visible = false;
                panel1.Visible = true;
            }
            else
            ShowStep(currentStep);
        }

        private void Finish()
        {
            MessageBox.Show("Izvještaj je spremljen.");



            // Ovdje spremi podatke u bazu itd. TODO
        }
    }
}
