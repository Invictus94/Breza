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
        public MainTreeView()
        {
            InitializeComponent();

            treeView1.Dock = DockStyle.Fill;
            treeView1.Nodes[0].Expand();

            Controls.Add(treeView1);
        }
    }
}
