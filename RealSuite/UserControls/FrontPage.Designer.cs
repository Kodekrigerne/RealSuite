namespace RealSuite.UserControls
{
    partial class FrontPage
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
            panel1 = new Panel();
            welcomeLabel = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 221, 177);
            panel1.Controls.Add(welcomeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 119);
            panel1.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold | FontStyle.Italic);
            welcomeLabel.Location = new Point(46, 41);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(211, 27);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Velkommen, Maria.";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.FrontFullLogo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(241, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 258);
            panel2.TabIndex = 1;
            // 
            // FrontPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrontPage";
            Size = new Size(812, 452);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label welcomeLabel;
        private Panel panel2;
    }
}
