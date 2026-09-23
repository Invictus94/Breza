using Breza.Helpers;
using Breza.Views;

namespace Breza
{
    public partial class Form1 : Form
    {
        private readonly System.Windows.Forms.Timer satTimer = new();
        public Form1()
        {
            InitializeComponent();

            mainTreeView1.NodeSelected += MainTreeView1_NodeSelected;

            labelIme.Text = Core.CurrentUser.Ime;
            PokreniSat();
        }

        private void PokreniSat()
        {
            satTimer.Interval = 1000;

            satTimer.Tick += (s, e) =>
            {
                labelSat.Text = DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss");
            };

            satTimer.Start();

            // odmah postavi vrijeme, bez čekanja prve sekunde
            labelSat.Text = DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss");
        }
        private void MainTreeView1_NodeSelected(object? sender, string nodeName)
        {
            switch (nodeName)
            {
                case "Korisnik":
                    ShowPage(new KorisnikPanel());
                    break;

                case "Djelatnik":
                    ShowPage(new DjelatnikPanel());
                    break;

                    //izvjesce
                case "Podnesi":
                    ShowPage(new IzvjescePanel());
                    break;

                case "Pretraži":
                    ShowPage(new PretraziIzvjescePanel());
                    break;
            }
        }

        private void ShowPage(UserControl page)
        {
            mainPanel.Controls.Clear();

            page.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(page);
        }
    }
}
