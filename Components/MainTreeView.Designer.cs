namespace Breza.Components
{
    partial class MainTreeView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Podnesi");
            TreeNode treeNode2 = new TreeNode("Pretraži");
            TreeNode treeNode3 = new TreeNode("Pregledaj");
            TreeNode treeNode4 = new TreeNode("Izvješće", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Segoe UI", 30F);
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Podnesi";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Pretraži";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Pregledaj";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Izvješće";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4 });
            treeView1.Size = new Size(326, 919);
            treeView1.TabIndex = 0;
            // 
            // MainTreeView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeView1);
            Name = "MainTreeView";
            Size = new Size(326, 919);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}
