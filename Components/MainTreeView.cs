using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Breza.Components
{
    public partial class MainTreeView : UserControl
    {
        public event EventHandler<string>? NodeSelected;
        public MainTreeView()
        {
            InitializeComponent();

            treeView1.Dock = DockStyle.Fill;

            var izvjesceNode = new TreeNode("Izvješće");
            izvjesceNode.Nodes.Add("Podnesi");
            izvjesceNode.Nodes.Add("Pretraži");
            izvjesceNode.Nodes.Add("Otvoreno");

            var dodajNode = new TreeNode("Dodaj");
            dodajNode.Nodes.Add("Korisnik");
            dodajNode.Nodes.Add("Djelatnik");

            izvjesceNode.Expand();

            treeView1.Nodes.Add(izvjesceNode);
            treeView1.Nodes.Add(dodajNode);

            treeView1.AfterSelect += (sender, e) => OnAfterSelect(e);

            Controls.Add(treeView1);
        }

        protected void OnAfterSelect(TreeViewEventArgs e)
        {
            NodeSelected?.Invoke(this, e.Node.Text);
        }
    }
}
