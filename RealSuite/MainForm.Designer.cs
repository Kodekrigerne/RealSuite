namespace RealSuite
{
    partial class MainForm
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
            splitContainer = new SplitContainer();
            label1 = new Label();
            panel1 = new Panel();
            addSellerButton = new Button();
            viewSellersButton = new Button();
            addPropertyButton = new Button();
            viewPropertiesButton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(3, 2, 3, 2);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.FromArgb(79, 117, 184);
            splitContainer.Panel1.Controls.Add(label1);
            splitContainer.Panel1.Controls.Add(panel1);
            splitContainer.Panel1.Controls.Add(addSellerButton);
            splitContainer.Panel1.Controls.Add(viewSellersButton);
            splitContainer.Panel1.Controls.Add(addPropertyButton);
            splitContainer.Panel1.Controls.Add(viewPropertiesButton);
            splitContainer.Panel1.Controls.Add(panel2);
            splitContainer.Panel1.Controls.Add(panel3);
            splitContainer.Size = new Size(992, 458);
            splitContainer.SplitterDistance = 175;
            splitContainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(65, 92, 143);
            label1.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 96);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 7;
            label1.Text = "Huse";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.FrontLogo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(45, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(81, 81);
            panel1.TabIndex = 6;
            panel1.Click += panel1_Click;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // addSellerButton
            // 
            addSellerButton.BackColor = Color.FromArgb(121, 160, 235);
            addSellerButton.Font = new Font("Microsoft YaHei", 9.75F);
            addSellerButton.ForeColor = Color.White;
            addSellerButton.Location = new Point(21, 376);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(138, 67);
            addSellerButton.TabIndex = 5;
            addSellerButton.Text = "Opret sælger";
            addSellerButton.UseVisualStyleBackColor = false;
            addSellerButton.MouseEnter += HighlightButton;
            addSellerButton.MouseLeave += StopHighlightButton;
            // 
            // viewSellersButton
            // 
            viewSellersButton.BackColor = Color.FromArgb(121, 160, 235);
            viewSellersButton.Font = new Font("Microsoft YaHei", 9.75F);
            viewSellersButton.ForeColor = Color.White;
            viewSellersButton.Location = new Point(21, 303);
            viewSellersButton.Name = "viewSellersButton";
            viewSellersButton.Size = new Size(138, 67);
            viewSellersButton.TabIndex = 4;
            viewSellersButton.Text = "Søg på sælger";
            viewSellersButton.UseVisualStyleBackColor = false;
            viewSellersButton.Click += viewSellersButton_Click;
            viewSellersButton.MouseEnter += HighlightButton;
            viewSellersButton.MouseLeave += StopHighlightButton;
            // 
            // addPropertyButton
            // 
            addPropertyButton.BackColor = Color.FromArgb(121, 160, 235);
            addPropertyButton.Font = new Font("Microsoft YaHei", 9.75F);
            addPropertyButton.ForeColor = Color.White;
            addPropertyButton.Location = new Point(21, 194);
            addPropertyButton.Name = "addPropertyButton";
            addPropertyButton.Size = new Size(138, 67);
            addPropertyButton.TabIndex = 2;
            addPropertyButton.Text = "Opret bolig";
            addPropertyButton.UseVisualStyleBackColor = false;
            addPropertyButton.Click += addPropertyButton_Click;
            addPropertyButton.MouseEnter += HighlightButton;
            addPropertyButton.MouseLeave += StopHighlightButton;
            // 
            // viewPropertiesButton
            // 
            viewPropertiesButton.BackColor = Color.FromArgb(121, 160, 235);
            viewPropertiesButton.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewPropertiesButton.ForeColor = Color.White;
            viewPropertiesButton.Location = new Point(21, 121);
            viewPropertiesButton.Name = "viewPropertiesButton";
            viewPropertiesButton.Size = new Size(138, 67);
            viewPropertiesButton.TabIndex = 1;
            viewPropertiesButton.Text = "Søg på bolig";
            viewPropertiesButton.UseVisualStyleBackColor = false;
            viewPropertiesButton.Click += viewPropertiesButton_Click;
            viewPropertiesButton.MouseEnter += HighlightButton;
            viewPropertiesButton.MouseLeave += StopHighlightButton;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 92, 143);
            panel2.Location = new Point(9, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 177);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(65, 92, 143);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(9, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 175);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(65, 92, 143);
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 3);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 8;
            label2.Text = "Sælgere";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 458);
            Controls.Add(splitContainer);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1008, 497);
            Name = "MainForm";
            Text = "RealSuite";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private UserControls.AddSellerPage addSellerPage;
        private Button addSellerButton;
        private Button viewSellersButton;
        private Button addPropertyButton;
        private Button viewPropertiesButton;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
    }
}
