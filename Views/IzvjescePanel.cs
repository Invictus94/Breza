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
        IDatabase database = Core.Database;
        private int currentStep = 0;
        Korisnik[] korisnici;
        private readonly List<UserControl> steps = new List<UserControl>();
        IzvjesceDnevno dnevno;

        public IzvjescePanel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            contentPanel.Visible = false;

            steps.Add(new UserControl());

            if (!Core.NODB_MODE)
            {
                var date = dateTimePicker1.Value.Date;
                dnevno = database.DohvatiIzvjesce(Core.CurrentUser, date, date.AddDays(1))?.FirstOrDefault() ?? null;
                var korisnici = database.DohvatiIzvjescaKorisnika(dnevno.Id);
                upisiKorisnike(korisnici);
            }

            if (dnevno == null)
            {
                dnevno = new IzvjesceDnevno();
                var date = dateTimePicker1.Value.Date;
                PostaviDefaultIzvjesce(date);
            }

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

            dateTimePicker1.ValueChanged += (s, e) =>
            {
                if (!Core.NODB_MODE && dateTimePicker1.Value.Date != dnevno.Datum.Date)
                {
                    var date = dateTimePicker1.Value.Date;
                    var result = database.DohvatiIzvjesce(Core.CurrentUser, date, date.AddDays(1).AddMinutes(-1));

                    if (result != null && result.Length > 0)
                    {
                        dnevno.WriteFrom(result[0]);
                        var korisnici = database.DohvatiIzvjescaKorisnika(dnevno.Id);
                        upisiKorisnike(korisnici);
                    }
                    else
                    {
                        PostaviDefaultIzvjesce(date);
                    }
                }
            };
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

        public void PostaviDefaultIzvjesce(DateTime datum)
        {
            var dnevnoNew = new IzvjesceDnevno();
            dnevnoNew.Datum = datum;
            dnevnoNew.DjelatnikId = Core.CurrentUser.Id;
            dnevnoNew.Id = dnevnoNew.DjelatnikId + dnevnoNew.Datum.ToString("dd_MM_yyyy");

            dnevno.WriteFrom(dnevnoNew);

            dohvatiKorisnike();
            upisiKorisnike(korisnici);
        }

        private void upisiKorisnike(Korisnik[] _korisnici)
        {
            steps.RemoveRange(1, steps.Count - 1);
            foreach (var korisnik in _korisnici)
            {
                var izvjesceKorisnik = new IzvjesceKorisnik()
                {
                    IzvjesceId = dnevno.Id,
                    KorisnikId = korisnik.Id,
                    Datum = dnevno.Datum,
                    DjelatnikId = dnevno.DjelatnikId,
                };

                steps.Add(new IzvjesceKorisnikPanel(izvjesceKorisnik, () => Back(), () => buttonDalje_Click(null, null)));
            }
        }

        private void upisiKorisnike(IzvjesceKorisnik[] izvjesceKorisnik)
        {
            steps.RemoveRange(1, steps.Count - 1);
            foreach (var korisnik in izvjesceKorisnik)
            {
                steps.Add(new IzvjesceKorisnikPanel(korisnik, () => Back(), () => buttonDalje_Click(null, null)));
            }
        }

        private void dohvatiKorisnike()
        {
            if (Core.NODB_MODE)
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

            DialogResult result = MessageBox.Show(
             $"Spremiti izvještaj {dnevno.Datum:dd.MM.yyyy}?",
             "Potvrda",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes && !Core.NODB_MODE)
            {
                if(dnevno.KreiranoDatum == default(DateTime))
                    dnevno.KreiranoDatum = DateTime.Now;

                var ok = database.DodajIzvjesce(
                    dnevno);

                foreach (IzvjesceKorisnikPanel item in steps.Skip(1))
                {
                    ok &= database.DodajIzvjesceKorisnika(item.IzvjesceKorisnik);
                }

                if (ok)
                {
                    MessageBox.Show(
                        $"Izvještaj {dnevno.Datum:dd.MM.yyyy} je uspješno spremljen.",
                        "Uspješno",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"Izvještaj nije spremljen.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
