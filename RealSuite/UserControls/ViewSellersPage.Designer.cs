namespace RealSuite.UserControls
{
    partial class ViewSellersPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            sellersDataGridView = new RealSuite.CustomControls.RsDataGridView();
            topPanel = new Panel();
            phoneNumberLabel = new Label();
            numberPanel = new Panel();
            phoneNumberComboBox = new ComboBox();
            zipCodeFilterLabel = new Label();
            zipCodePanel = new Panel();
            zipCodeComboBox = new ComboBox();
            resultsLabel = new Label();
            clearButtonIconPanel = new Panel();
            refreshIconPanel = new Panel();
            clearButton = new Button();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)sellersDataGridView).BeginInit();
            topPanel.SuspendLayout();
            numberPanel.SuspendLayout();
            zipCodePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sellersDataGridView
            // 
            dataGridViewCellStyle1.NullValue = null;
            sellersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            sellersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            sellersDataGridView.ColumnHeadersHeight = 4;
            sellersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 221, 177);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            sellersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            sellersDataGridView.Location = new Point(0, 135);
            sellersDataGridView.Name = "sellersDataGridView";
            sellersDataGridView.Size = new Size(812, 317);
            sellersDataGridView.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(228, 221, 177);
            topPanel.Controls.Add(phoneNumberLabel);
            topPanel.Controls.Add(numberPanel);
            topPanel.Controls.Add(zipCodeFilterLabel);
            topPanel.Controls.Add(zipCodePanel);
            topPanel.Controls.Add(resultsLabel);
            topPanel.Controls.Add(clearButtonIconPanel);
            topPanel.Controls.Add(refreshIconPanel);
            topPanel.Controls.Add(clearButton);
            topPanel.Controls.Add(refreshButton);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(812, 136);
            topPanel.TabIndex = 2;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.FromArgb(100, 131, 184);
            phoneNumberLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(109, 12);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(48, 19);
            phoneNumberLabel.TabIndex = 25;
            phoneNumberLabel.Text = "Tlfnr.";
            // 
            // numberPanel
            // 
            numberPanel.BackColor = Color.FromArgb(179, 215, 232);
            numberPanel.Controls.Add(phoneNumberComboBox);
            numberPanel.Location = new Point(109, 31);
            numberPanel.Name = "numberPanel";
            numberPanel.Size = new Size(110, 39);
            numberPanel.TabIndex = 24;
            // 
            // phoneNumberComboBox
            // 
            phoneNumberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phoneNumberComboBox.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumberComboBox.FormattingEnabled = true;
            phoneNumberComboBox.Items.AddRange(new object[] { "Alle" });
            phoneNumberComboBox.Location = new Point(8, 6);
            phoneNumberComboBox.Name = "phoneNumberComboBox";
            phoneNumberComboBox.Size = new Size(95, 27);
            phoneNumberComboBox.TabIndex = 22;
            phoneNumberComboBox.SelectedValueChanged += phoneNumberComboBox_SelectedValueChanged;
            // 
            // zipCodeFilterLabel
            // 
            zipCodeFilterLabel.AutoSize = true;
            zipCodeFilterLabel.BackColor = Color.FromArgb(100, 131, 184);
            zipCodeFilterLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            zipCodeFilterLabel.ForeColor = Color.White;
            zipCodeFilterLabel.Location = new Point(14, 12);
            zipCodeFilterLabel.Name = "zipCodeFilterLabel";
            zipCodeFilterLabel.Size = new Size(58, 19);
            zipCodeFilterLabel.TabIndex = 24;
            zipCodeFilterLabel.Text = "Postnr";
            // 
            // zipCodePanel
            // 
            zipCodePanel.BackColor = Color.FromArgb(179, 215, 232);
            zipCodePanel.Controls.Add(zipCodeComboBox);
            zipCodePanel.Location = new Point(14, 31);
            zipCodePanel.Name = "zipCodePanel";
            zipCodePanel.Size = new Size(79, 39);
            zipCodePanel.TabIndex = 23;
            // 
            // zipCodeComboBox
            // 
            zipCodeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            zipCodeComboBox.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zipCodeComboBox.FormattingEnabled = true;
            zipCodeComboBox.Items.AddRange(new object[] { "Alle" });
            zipCodeComboBox.Location = new Point(8, 6);
            zipCodeComboBox.Name = "zipCodeComboBox";
            zipCodeComboBox.Size = new Size(64, 27);
            zipCodeComboBox.TabIndex = 22;
            zipCodeComboBox.SelectedValueChanged += zipCodeComboBox_SelectedValueChanged;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = Color.FromArgb(243, 239, 218);
            resultsLabel.Font = new Font("Microsoft YaHei", 10.5F, FontStyle.Italic);
            resultsLabel.Location = new Point(12, 105);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(15, 20);
            resultsLabel.TabIndex = 21;
            resultsLabel.Text = "-";
            // 
            // clearButtonIconPanel
            // 
            clearButtonIconPanel.BackColor = Color.PeachPuff;
            clearButtonIconPanel.BackgroundImage = Properties.Resources.ClearPropertyFiltersIcon;
            clearButtonIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            clearButtonIconPanel.Location = new Point(764, 97);
            clearButtonIconPanel.Name = "clearButtonIconPanel";
            clearButtonIconPanel.Size = new Size(26, 27);
            clearButtonIconPanel.TabIndex = 11;
            // 
            // refreshIconPanel
            // 
            refreshIconPanel.BackColor = Color.FromArgb(142, 221, 188);
            refreshIconPanel.BackgroundImage = Properties.Resources.Refresh_Properties_Logo;
            refreshIconPanel.BackgroundImageLayout = ImageLayout.Stretch;
            refreshIconPanel.Location = new Point(621, 99);
            refreshIconPanel.Name = "refreshIconPanel";
            refreshIconPanel.Size = new Size(23, 23);
            refreshIconPanel.TabIndex = 10;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.PeachPuff;
            clearButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            clearButton.Location = new Point(671, 89);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(128, 43);
            clearButton.TabIndex = 9;
            clearButton.Text = "Ryd filtre     ";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            clearButton.MouseDown += ClearButton_MouseDown;
            clearButton.MouseEnter += ClearButton_MouseEnter;
            clearButton.MouseLeave += ClearButton_MouseLeave;
            clearButton.MouseUp += ClearButton_MouseUp;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(148, 216, 200);
            refreshButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            refreshButton.Location = new Point(509, 89);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(146, 43);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Genindlæs    ";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            refreshButton.MouseDown += RefreshButton_MouseDown;
            refreshButton.MouseEnter += RefreshButton_MouseEnter;
            refreshButton.MouseLeave += RefreshButton_MouseLeave;
            refreshButton.MouseUp += RefreshButton_MouseUp;
            // 
            // ViewSellersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(topPanel);
            Controls.Add(sellersDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewSellersPage";
            Size = new Size(812, 452);
            ((System.ComponentModel.ISupportInitialize)sellersDataGridView).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            numberPanel.ResumeLayout(false);
            zipCodePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RsDataGridView sellersDataGridView;
        private Panel topPanel;
        private Label zipCodeFilterLabel;
        private Panel zipCodePanel;
        private ComboBox zipCodeComboBox;
        private Label resultsLabel;
        private Label soldFilterLabel;
        private Panel soldFilterPanel;
        private Panel clearButtonIconPanel;
        private Panel refreshIconPanel;
        private Button clearButton;
        private Button refreshButton;
        private Panel numberPanel;
        private ComboBox phoneNumberComboBox;
        private Label phoneNumberLabel;
        private Panel panel7;
    }
}
