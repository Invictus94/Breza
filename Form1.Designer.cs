namespace Breza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTreeView1 = new Breza.Components.MainTreeView();
            tableLayoutPanel1 = new TableLayoutPanel();
            mainPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTreeView1
            // 
            mainTreeView1.Dock = DockStyle.Fill;
            mainTreeView1.Location = new Point(3, 3);
            mainTreeView1.Name = "mainTreeView1";
            mainTreeView1.Size = new Size(388, 1072);
            mainTreeView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5714283F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.42857F));
            tableLayoutPanel1.Controls.Add(mainTreeView1, 0, 0);
            tableLayoutPanel1.Controls.Add(mainPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1673, 1078);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(397, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1273, 1072);
            mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 1078);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Početna";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Components.MainTreeView mainTreeView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel mainPanel;
    }
}
