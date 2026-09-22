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
            labelSat = new Label();
            mainPanel = new Panel();
            labelIme = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTreeView1
            // 
            mainTreeView1.Dock = DockStyle.Fill;
            mainTreeView1.Location = new Point(3, 73);
            mainTreeView1.Name = "mainTreeView1";
            mainTreeView1.Size = new Size(388, 1002);
            mainTreeView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelIme, 0, 0);
            tableLayoutPanel1.Controls.Add(labelSat, 1, 0);
            tableLayoutPanel1.Controls.Add(mainTreeView1, 0, 1);
            tableLayoutPanel1.Controls.Add(mainPanel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel1.Size = new Size(1673, 1078);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelSat
            // 
            labelSat.Anchor = AnchorStyles.Right;
            labelSat.AutoSize = true;
            labelSat.Font = new Font("Segoe UI", 26F);
            labelSat.Location = new Point(1555, 0);
            labelSat.Name = "labelSat";
            labelSat.Size = new Size(115, 70);
            labelSat.TabIndex = 2;
            labelSat.Text = "SAT";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(397, 73);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1273, 1002);
            mainPanel.TabIndex = 1;
            // 
            // labelIme
            // 
            labelIme.Anchor = AnchorStyles.Left;
            labelIme.AutoSize = true;
            labelIme.Font = new Font("Segoe UI", 24F);
            labelIme.Location = new Point(3, 2);
            labelIme.Name = "labelIme";
            labelIme.Size = new Size(108, 65);
            labelIme.TabIndex = 1;
            labelIme.Text = "IME";
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
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.MainTreeView mainTreeView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel mainPanel;
        private Label labelSat;
        private Label labelIme;
    }
}
