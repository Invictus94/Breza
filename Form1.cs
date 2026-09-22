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

                case "Odgajatelj":
                   // ShowPage(new DrugaStranica());
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
