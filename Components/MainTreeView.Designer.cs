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
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Segoe UI", 30F);
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
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
