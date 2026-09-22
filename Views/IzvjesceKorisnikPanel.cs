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
    public partial class IzvjesceKorisnikPanel : UserControl
    {
        IDatabase database = Core.Database;
        private bool postavljamOcjenu = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IzvjesceKorisnik IzvjesceKorisnik { get; set; }
        Action BackButton;
        Action NextButton;
        public IzvjesceKorisnikPanel(IzvjesceKorisnik _korisnik, Action _back, Action _next)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            this.IzvjesceKorisnik = _korisnik;
            this.BackButton = _back;
            this.NextButton = _next;

            var korisnik = database.DohvatiKorisnika(IzvjesceKorisnik.KorisnikId);

            labelImeKorisnik.Text = $"{korisnik?.Ime} {korisnik?.Prezime}";

            var statusi = Enum.GetValues<KorisnikStatus>()
                .Select(x => new
                {
                    Value = x,
                    Text = x.ToString().Replace("_", " ")
                })
                .ToList();

            comboBoxStatus.DataSource = statusi;
            comboBoxStatus.DisplayMember = "Text";
            comboBoxStatus.ValueMember = "Value";

            textBoxNapomena.DataBindings.Add(
                "Text",
                IzvjesceKorisnik,
                nameof(Models.IzvjesceKorisnik.Napomena),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            //        textBoxPrezime.DataBindings.Add(
            //            "Text",
            //            djelatnik,
            //            nameof(Djelatnik.Prezime),
            //            true,
            //            DataSourceUpdateMode.OnPropertyChanged);

            comboBoxStatus.DataBindings.Add(
                "SelectedValue",
                IzvjesceKorisnik,
                nameof(Models.IzvjesceKorisnik.Status),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            upisiOcjenu();
            postaviOcjenu(IzvjesceKorisnik.Ocjena);
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
        private void postaviOcjenu(KorisnikOcjena ocjena)
        {
            if (postavljamOcjenu)
                return;

            postavljamOcjenu = true;

            try
            {
                // Spremi u model
                IzvjesceKorisnik.Ocjena = ocjena;

                // Postavi checkboxe
                checkBox1.Checked = ocjena == KorisnikOcjena.Lose;
                checkBox2.Checked = ocjena == KorisnikOcjena.Slabo;
                checkBox3.Checked = ocjena == KorisnikOcjena.Dobro;
                checkBox4.Checked = ocjena == KorisnikOcjena.VrloDobro;
                checkBox5.Checked = ocjena == KorisnikOcjena.Odlicno;
            }
            finally
            {
                postavljamOcjenu = false;
            }
        }

        void upisiOcjenu()
        {
            checkBox1.CheckedChanged += (s, e) =>
            {
                if (checkBox1.Checked)
                    postaviOcjenu(KorisnikOcjena.Lose);
            };

            checkBox2.CheckedChanged += (s, e) =>
            {
                if (checkBox2.Checked)
                    postaviOcjenu(KorisnikOcjena.Slabo);
            };

            checkBox3.CheckedChanged += (s, e) =>
            {
                if (checkBox3.Checked)
                    postaviOcjenu(KorisnikOcjena.Dobro);
            };

            checkBox4.CheckedChanged += (s, e) =>
            {
                if (checkBox4.Checked)
                    postaviOcjenu(KorisnikOcjena.VrloDobro);
            };

            checkBox5.CheckedChanged += (s, e) =>
            {
                if (checkBox5.Checked)
                    postaviOcjenu(KorisnikOcjena.Odlicno);
            };
        }


        void NazadClick(object sender, EventArgs e)
        {
            BackButton?.Invoke();
        }

        void DaljeClick(object sender, EventArgs e)
        {
            NextButton?.Invoke();
        }
    }
}
