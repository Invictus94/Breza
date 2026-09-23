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
    public partial class PretraziIzvjescePanel : UserControl
    {
        IDatabase database = Core.Database;
        public PretraziIzvjescePanel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            dohvatiDjelatnike();
            dohvatiKorisnike();
            postaviStatusIzvjesca();

            dateTimePickerOd.ValueChanged += (s, e) =>
            {
                if(dateTimePickerDo.Checked != dateTimePickerOd.Checked)
                {
                    dateTimePickerDo.Checked = dateTimePickerOd.Checked;
                }
            };

            dateTimePickerDo.ValueChanged += (s, e) =>
            {
                if (dateTimePickerDo.Checked != dateTimePickerOd.Checked)
                {
                    dateTimePickerOd.Checked = dateTimePickerDo.Checked;
                }
            };
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

        void dohvatiDjelatnike()
        {
            var djelatnici = database.DohvatiDjelatnike();

            var lista = djelatnici
                .Select(x => new
                {
                    Djelatnik = x,
                    ImePrezime = $"{x.Ime} {x.Prezime}"
                })
                .ToList();

            var currentUser = lista.FirstOrDefault(x => x.Djelatnik.Id == Core.CurrentUser.Id) ?? null;

            if (currentUser != null)
            {
                lista.Remove(currentUser);
                lista.Insert(0, currentUser);
            }

            comboBoxDjelatnik.DisplayMember = "ImePrezime";
            comboBoxDjelatnik.ValueMember = "Djelatnik";
            comboBoxDjelatnik.DataSource = lista;
        }

        void dohvatiKorisnike()
        {
            var korisnici = database.DohvatiKorisnike();

            var lista = korisnici
                .Select(x => new
                {
                    Korisnik = x,
                    ImePrezime = $"{x.Ime} {x.Prezime}"
                })
                .ToList();

            lista.Insert(0, new
            {
                Korisnik = (Korisnik)null,
                ImePrezime = "-"
            });

            comboBoxKorisnik.DataSource = lista;
            comboBoxKorisnik.DisplayMember = "ImePrezime";
            comboBoxKorisnik.ValueMember = "Korisnik";
        }

        void postaviStatusIzvjesca()
        {
            var statusi = Enum.GetValues<IzvjesceStatus>()
                .Select(x => new
                {
                    Status = (IzvjesceStatus?)x,
                    Naziv = x.ToString()
                })
                .ToList();

            statusi.Insert(0, new
            {
                Status = (IzvjesceStatus?)null,
                Naziv = "-"
            });

            comboBoxStatusIzvj.DataSource = statusi;
            comboBoxStatusIzvj.DisplayMember = "Naziv";
            comboBoxStatusIzvj.ValueMember = "Status";

            //IzvjesceStatus? status =
            //(IzvjesceStatus?)comboBoxStatusIzvj.SelectedValue;
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            var djelatnik = comboBoxDjelatnik.SelectedValue as Djelatnik;
            var korisnik = comboBoxKorisnik.SelectedValue as Korisnik;

            IzvjesceStatus? status =
                comboBoxStatusIzvj.SelectedValue == null
                    ? null
                    : (IzvjesceStatus)comboBoxStatusIzvj.SelectedValue;

            DateTime datumOd;
            DateTime datumDo;

            bool isDatumChecked =
                dateTimePickerOd.Checked &&
                dateTimePickerDo.Checked;

            if (isDatumChecked)
            {
                datumOd = dateTimePickerOd.Value.Date;
                datumDo = dateTimePickerDo.Value.Date;
            }
            else
            {
                datumDo = DateTime.Today.AddDays(1);
                datumOd = datumDo.AddMonths(-3);
            }

            Izvjesce[] izvjesca;

            if (djelatnik != null && korisnik != null)
            {
                izvjesca = database.DohvatiIzvjesce(
                    djelatnik,
                    korisnik,
                    datumOd,
                    datumDo,
                    status);
            }
            else if (djelatnik != null)
            {
                izvjesca = database.DohvatiIzvjesce(
                    djelatnik,
                    datumOd,
                    datumDo,
                    status);
            }
            else if (korisnik != null)
            {
                izvjesca = database.DohvatiIzvjesce(
                    korisnik,
                    datumOd,
                    datumDo,
                    status);
            }
            else
            {
                izvjesca = database.DohvatiIzvjesce(
                    datumOd,
                    datumDo,
                    status);
            }

            // rezultat pretrage
        }
    }
}
