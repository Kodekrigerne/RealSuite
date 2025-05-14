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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer = new SplitContainer();
            LogoPanel = new Panel();
            addSellerButton = new Button();
            viewSellersButton = new Button();
            addPropertyButton = new Button();
            viewPropertiesButton = new Button();
            BgPanelProperties = new Panel();
            PropertiesLabel = new Label();
            BgPanelSellers = new Panel();
            SellersLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            BgPanelProperties.SuspendLayout();
            BgPanelSellers.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(79, 117, 184);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.FromArgb(79, 117, 184);
            splitContainer.Panel1.Controls.Add(LogoPanel);
            splitContainer.Panel1.Controls.Add(addSellerButton);
            splitContainer.Panel1.Controls.Add(viewSellersButton);
            splitContainer.Panel1.Controls.Add(addPropertyButton);
            splitContainer.Panel1.Controls.Add(viewPropertiesButton);
            splitContainer.Panel1.Controls.Add(BgPanelProperties);
            splitContainer.Panel1.Controls.Add(BgPanelSellers);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = Color.White;
            splitContainer.Size = new Size(1134, 611);
            splitContainer.SplitterDistance = 200;
            splitContainer.SplitterWidth = 5;
            splitContainer.TabIndex = 0;
            splitContainer.TabStop = false;
            // 
            // LogoPanel
            // 
            LogoPanel.BackgroundImage = Properties.Resources.FrontLogo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Stretch;
            LogoPanel.Location = new Point(57, 5);
            LogoPanel.Margin = new Padding(3, 4, 3, 4);
            LogoPanel.Name = "LogoPanel";
            LogoPanel.Size = new Size(93, 108);
            LogoPanel.TabIndex = 6;
            LogoPanel.Click += LogoPanel_Click;
            LogoPanel.MouseDown += LogoPanel_MouseDown;
            LogoPanel.MouseEnter += LogoPanel_MouseEnter;
            LogoPanel.MouseLeave += LogoPanel_MouseLeave;
            LogoPanel.MouseUp += LogoPanel_MouseUp;
            // 
            // addSellerButton
            // 
            addSellerButton.BackColor = Color.FromArgb(121, 160, 235);
            addSellerButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            addSellerButton.ForeColor = Color.White;
            addSellerButton.Location = new Point(25, 501);
            addSellerButton.Margin = new Padding(3, 4, 3, 4);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(158, 89);
            addSellerButton.TabIndex = 5;
            addSellerButton.TabStop = false;
            addSellerButton.Text = "Opret sælger";
            addSellerButton.UseVisualStyleBackColor = false;
            addSellerButton.Click += AddSellerButton_Click;
            addSellerButton.MouseDown += HighlightClickButton;
            addSellerButton.MouseEnter += HighlightButton;
            addSellerButton.MouseLeave += StopHighlightButton;
            addSellerButton.MouseUp += HighlightButton;
            // 
            // viewSellersButton
            // 
            viewSellersButton.BackColor = Color.FromArgb(121, 160, 235);
            viewSellersButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            viewSellersButton.ForeColor = Color.White;
            viewSellersButton.Location = new Point(25, 404);
            viewSellersButton.Margin = new Padding(3, 4, 3, 4);
            viewSellersButton.Name = "viewSellersButton";
            viewSellersButton.Size = new Size(158, 89);
            viewSellersButton.TabIndex = 4;
            viewSellersButton.TabStop = false;
            viewSellersButton.Text = "Se sælgere";
            viewSellersButton.UseVisualStyleBackColor = false;
            viewSellersButton.Click += ViewSellersButton_Click;
            viewSellersButton.MouseDown += HighlightClickButton;
            viewSellersButton.MouseEnter += HighlightButton;
            viewSellersButton.MouseLeave += StopHighlightButton;
            viewSellersButton.MouseUp += HighlightButton;
            // 
            // addPropertyButton
            // 
            addPropertyButton.BackColor = Color.FromArgb(121, 160, 235);
            addPropertyButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            addPropertyButton.ForeColor = Color.White;
            addPropertyButton.Location = new Point(25, 259);
            addPropertyButton.Margin = new Padding(3, 4, 3, 4);
            addPropertyButton.Name = "addPropertyButton";
            addPropertyButton.Size = new Size(158, 89);
            addPropertyButton.TabIndex = 2;
            addPropertyButton.TabStop = false;
            addPropertyButton.Text = "Opret bolig";
            addPropertyButton.UseVisualStyleBackColor = false;
            addPropertyButton.Click += AddPropertyButton_Click;
            addPropertyButton.MouseDown += HighlightClickButton;
            addPropertyButton.MouseEnter += HighlightButton;
            addPropertyButton.MouseLeave += StopHighlightButton;
            addPropertyButton.MouseUp += HighlightButton;
            // 
            // viewPropertiesButton
            // 
            viewPropertiesButton.BackColor = Color.FromArgb(121, 160, 235);
            viewPropertiesButton.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            viewPropertiesButton.ForeColor = Color.White;
            viewPropertiesButton.Location = new Point(25, 161);
            viewPropertiesButton.Margin = new Padding(3, 4, 3, 4);
            viewPropertiesButton.Name = "viewPropertiesButton";
            viewPropertiesButton.Size = new Size(158, 89);
            viewPropertiesButton.TabIndex = 1;
            viewPropertiesButton.TabStop = false;
            viewPropertiesButton.Text = "Se boliger";
            viewPropertiesButton.UseVisualStyleBackColor = false;
            viewPropertiesButton.Click += ViewPropertiesButton_Click;
            viewPropertiesButton.MouseDown += HighlightClickButton;
            viewPropertiesButton.MouseEnter += HighlightButton;
            viewPropertiesButton.MouseLeave += StopHighlightButton;
            viewPropertiesButton.MouseUp += HighlightButton;
            // 
            // BgPanelProperties
            // 
            BgPanelProperties.BackColor = Color.FromArgb(65, 92, 143);
            BgPanelProperties.Controls.Add(PropertiesLabel);
            BgPanelProperties.Location = new Point(11, 121);
            BgPanelProperties.Margin = new Padding(3, 4, 3, 4);
            BgPanelProperties.Name = "BgPanelProperties";
            BgPanelProperties.Size = new Size(183, 236);
            BgPanelProperties.TabIndex = 7;
            // 
            // PropertiesLabel
            // 
            PropertiesLabel.AutoSize = true;
            PropertiesLabel.BackColor = Color.FromArgb(65, 92, 143);
            PropertiesLabel.Font = new Font("Microsoft YaHei", 12F);
            PropertiesLabel.ForeColor = Color.LightSteelBlue;
            PropertiesLabel.Location = new Point(58, 8);
            PropertiesLabel.Name = "PropertiesLabel";
            PropertiesLabel.Size = new Size(80, 27);
            PropertiesLabel.TabIndex = 7;
            PropertiesLabel.Text = "Boliger";
            // 
            // BgPanelSellers
            // 
            BgPanelSellers.BackColor = Color.FromArgb(65, 92, 143);
            BgPanelSellers.Controls.Add(SellersLabel);
            BgPanelSellers.Location = new Point(11, 368);
            BgPanelSellers.Margin = new Padding(3, 4, 3, 4);
            BgPanelSellers.Name = "BgPanelSellers";
            BgPanelSellers.Size = new Size(183, 233);
            BgPanelSellers.TabIndex = 8;
            // 
            // SellersLabel
            // 
            SellersLabel.AutoSize = true;
            SellersLabel.BackColor = Color.FromArgb(65, 92, 143);
            SellersLabel.Font = new Font("Microsoft YaHei", 12F);
            SellersLabel.ForeColor = Color.LightSteelBlue;
            SellersLabel.Location = new Point(51, 4);
            SellersLabel.Name = "SellersLabel";
            SellersLabel.Size = new Size(90, 27);
            SellersLabel.TabIndex = 8;
            SellersLabel.Text = "Sælgere";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 611);
            Controls.Add(splitContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1147, 642);
            Name = "MainForm";
            Text = "RealSuite";
            splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            BgPanelProperties.ResumeLayout(false);
            BgPanelProperties.PerformLayout();
            BgPanelSellers.ResumeLayout(false);
            BgPanelSellers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private UserControls.AddSellerPage addSellerPage;
        private Button addSellerButton;
        private Button viewSellersButton;
        private Button addPropertyButton;
        private Button viewPropertiesButton;
        private Panel LogoPanel;
        private Label SellersLabel;
        private Label PropertiesLabel;
        private Panel BgPanelProperties;
        private Panel BgPanelSellers;
    }
}
