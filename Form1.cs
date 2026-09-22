using Breza.Views;

namespace Breza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mainTreeView1.NodeSelected += MainTreeView1_NodeSelected;
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
