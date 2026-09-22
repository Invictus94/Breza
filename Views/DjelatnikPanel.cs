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
    public partial class DjelatnikPanel : UserControl
    {
        IDatabase database;
        Djelatnik djelatnik = new Djelatnik();
        public DjelatnikPanel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            comboBoxOvlasti.DataSource = Enum.GetValues<UserRole>();

            textBoxIme.DataBindings.Add(
    "Text",
    djelatnik,
    nameof(Djelatnik.Ime),
    true,
    DataSourceUpdateMode.OnPropertyChanged);

            textBoxPrezime.DataBindings.Add(
                "Text",
                djelatnik,
                nameof(Djelatnik.Prezime),
                true,
                DataSourceUpdateMode.OnPropertyChanged);

            comboBoxOvlasti.DataBindings.Add(
    "SelectedItem",
    djelatnik,
    nameof(Djelatnik.Ovlasti),
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Dodati djelatnika:\n\n{djelatnik.Ime} {djelatnik.Prezime} kao {djelatnik.Ovlasti}?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var ok = database.DodajDjelatnika(
                    djelatnik);

                if (ok)
                {
                    MessageBox.Show(
                        $"Djelatnik {textBoxIme.Text} {textBoxPrezime.Text} je uspješno dodan.",
                        "Uspješno",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"Djelatnik {textBoxIme.Text} {textBoxPrezime.Text} nije dodan.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
