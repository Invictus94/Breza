using Breza.Helpers;
using Breza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Breza.Views
{
    public partial class IzvjescePregled : UserControl
    {
        IDatabase database = Core.Database;
        Action BackButton;
        Action NextButton;
        Djelatnik[] djelatnici;
        Izvjesce[] izvjesceOriginal;
        public IzvjescePregled(Izvjesce[] izvjesca = null, Action _back = null, Action _next = null)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            buttonNazad.Visible = false;
            BackButton = _back;
            NextButton = _next;
            
            djelatnici = database.DohvatiDjelatnike();

            if (izvjesca == null)
            {
                dohvatiSvaIzvjescaOveGodine();
            }
            else
            {
                srediZaDataSource(izvjesca);
            }

            if (BackButton != null)
            {
                buttonNazad.Visible = true;
                buttonNazad.Click += (s, e) => BackButton?.Invoke();
            }
        }

        private void dohvatiSvaIzvjescaOveGodine()
        {
            var date = DateTime.Now;
            var dateThisYear = new DateTime(date.Year, 1, 1);
            var izvjesca = database.DohvatiIzvjesce(dateThisYear, dateThisYear.AddYears(1));
            srediZaDataSource(izvjesca);
        }

        private void srediZaDataSource(Izvjesce[] izvjesca)
        {
            izvjesceOriginal = izvjesca;

            var izvjescaZaPrikaz = izvjesca
    .Select(x => new
    {
        x.Datum,
        Djelatnik = djelatnici
            .FirstOrDefault(d => d.Id == x.DjelatnikId) is var d && d != null
                ? $"{d.Ime} {d.Prezime}"
                : "-",
        x.Status,
        Kreirano = x.KreiranoDatum,
    })
    .OrderByDescending(x => x.Datum)
    .ToList();

            dataGridView1.DataSource = izvjescaZaPrikaz;
        }

        private void CenterPanel()
        {
            return;
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterPanel();
        }

    }
}
