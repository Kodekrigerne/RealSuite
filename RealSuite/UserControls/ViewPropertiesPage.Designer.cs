﻿using RealSuite.CustomControls;

namespace RealSuite.UserControls
{
    partial class ViewPropertiesPage
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
            propertiesDataGridView = new RsDataGridView();
            topPanel = new Panel();
            searchInfoPictureBox = new PictureBox();
            sletBolig_button = new Button();
            saveToFileButton = new Button();
            clearTextButton = new Label();
            searchTextBox = new TextBox();
            zipCodeFilterLabel = new Label();
            zipCodePanel = new Panel();
            zipCodeComboBox = new ComboBox();
            resultsLabel = new Label();
            sellerFilterLabel = new Label();
            soldFilterLabel = new Label();
            soldFilterPanel = new Panel();
            soldComboBox = new ComboBox();
            clearButtonIconLabel = new Panel();
            refreshButtonIconLabel = new Panel();
            clearButton = new Button();
            refreshButton = new Button();
            priceFromFilterPanel = new Panel();
            maxPriceTrackBar = new TrackBar();
            minPriceTrackBar = new TrackBar();
            selectedMaxPriceLabel = new Label();
            selectedMinPriceLabel = new Label();
            minPriceLabel = new Label();
            maxPriceLabel = new Label();
            soldDatePickerLabel = new Panel();
            soldFromDatePicker = new DateTimePicker();
            soldDateToLabel = new Label();
            soldDateFromLabel = new Label();
            soldToDatePicker = new DateTimePicker();
            sellerComboBoxLabel = new Panel();
            sellerComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchInfoPictureBox).BeginInit();
            zipCodePanel.SuspendLayout();
            soldFilterPanel.SuspendLayout();
            priceFromFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).BeginInit();
            soldDatePickerLabel.SuspendLayout();
            sellerComboBoxLabel.SuspendLayout();
            SuspendLayout();
            // 
            // propertiesDataGridView
            // 
            dataGridViewCellStyle1.NullValue = null;
            propertiesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            propertiesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            propertiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            propertiesDataGridView.ColumnHeadersHeight = 4;
            propertiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 221, 177);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            propertiesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            propertiesDataGridView.Location = new Point(0, 182);
            propertiesDataGridView.Margin = new Padding(4);
            propertiesDataGridView.Name = "propertiesDataGridView";
            propertiesDataGridView.Size = new Size(928, 421);
            propertiesDataGridView.TabIndex = 0;
            propertiesDataGridView.CellClick += propertiesDataGridView_CellClick;
            propertiesDataGridView.CellDoubleClick += PropertiesDataGridView_CellDoubleClick;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(228, 221, 177);
            topPanel.Controls.Add(searchInfoPictureBox);
            topPanel.Controls.Add(sletBolig_button);
            topPanel.Controls.Add(saveToFileButton);
            topPanel.Controls.Add(clearTextButton);
            topPanel.Controls.Add(searchTextBox);
            topPanel.Controls.Add(zipCodeFilterLabel);
            topPanel.Controls.Add(zipCodePanel);
            topPanel.Controls.Add(resultsLabel);
            topPanel.Controls.Add(sellerFilterLabel);
            topPanel.Controls.Add(soldFilterLabel);
            topPanel.Controls.Add(soldFilterPanel);
            topPanel.Controls.Add(clearButtonIconLabel);
            topPanel.Controls.Add(refreshButtonIconLabel);
            topPanel.Controls.Add(clearButton);
            topPanel.Controls.Add(refreshButton);
            topPanel.Controls.Add(priceFromFilterPanel);
            topPanel.Controls.Add(soldDatePickerLabel);
            topPanel.Controls.Add(sellerComboBoxLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(928, 181);
            topPanel.TabIndex = 1;
            topPanel.Click += TopPanel_Click;
            // 
            // searchInfoPictureBox
            // 
            searchInfoPictureBox.Location = new Point(236, 102);
            searchInfoPictureBox.Margin = new Padding(1);
            searchInfoPictureBox.Name = "searchInfoPictureBox";
            searchInfoPictureBox.Size = new Size(18, 19);
            searchInfoPictureBox.TabIndex = 28;
            searchInfoPictureBox.TabStop = false;
            // 
            // sletBolig_button
            // 
            sletBolig_button.Enabled = false;
            sletBolig_button.Location = new Point(477, 138);
            sletBolig_button.Name = "sletBolig_button";
            sletBolig_button.Size = new Size(94, 29);
            sletBolig_button.TabIndex = 27;
            sletBolig_button.Text = "Slet bolig";
            sletBolig_button.UseVisualStyleBackColor = true;
            sletBolig_button.Click += sletBolig_button_Click;
            // 
            // saveToFileButton
            // 
            saveToFileButton.Location = new Point(373, 138);
            saveToFileButton.Name = "saveToFileButton";
            saveToFileButton.Size = new Size(101, 29);
            saveToFileButton.TabIndex = 25;
            saveToFileButton.Text = "Gem liste";
            saveToFileButton.UseVisualStyleBackColor = true;
            saveToFileButton.Click += SaveToFileButton_Click;
            // 
            // clearTextButton
            // 
            clearTextButton.AutoSize = true;
            clearTextButton.BackColor = Color.White;
            clearTextButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearTextButton.ForeColor = Color.Red;
            clearTextButton.Location = new Point(207, 100);
            clearTextButton.Name = "clearTextButton";
            clearTextButton.Size = new Size(21, 23);
            clearTextButton.TabIndex = 26;
            clearTextButton.Text = "X";
            clearTextButton.Visible = false;
            clearTextButton.Click += ClearTextButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Microsoft YaHei", 9.75F);
            searchTextBox.Location = new Point(14, 99);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(220, 29);
            searchTextBox.TabIndex = 25;
            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            searchTextBox.KeyDown += SearchTextBox_KeyDown;
            // 
            // zipCodeFilterLabel
            // 
            zipCodeFilterLabel.AutoSize = true;
            zipCodeFilterLabel.BackColor = Color.FromArgb(100, 131, 184);
            zipCodeFilterLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            zipCodeFilterLabel.ForeColor = Color.White;
            zipCodeFilterLabel.Location = new Point(279, 11);
            zipCodeFilterLabel.Name = "zipCodeFilterLabel";
            zipCodeFilterLabel.Size = new Size(73, 26);
            zipCodeFilterLabel.TabIndex = 24;
            zipCodeFilterLabel.Text = "Postnr";
            // 
            // zipCodePanel
            // 
            zipCodePanel.BackColor = Color.FromArgb(179, 215, 232);
            zipCodePanel.Controls.Add(zipCodeComboBox);
            zipCodePanel.Location = new Point(279, 36);
            zipCodePanel.Margin = new Padding(3, 4, 3, 4);
            zipCodePanel.Name = "zipCodePanel";
            zipCodePanel.Size = new Size(90, 52);
            zipCodePanel.TabIndex = 23;
            // 
            // zipCodeComboBox
            // 
            zipCodeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            zipCodeComboBox.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zipCodeComboBox.FormattingEnabled = true;
            zipCodeComboBox.Items.AddRange(new object[] { "Alle" });
            zipCodeComboBox.Location = new Point(9, 8);
            zipCodeComboBox.Margin = new Padding(3, 4, 3, 4);
            zipCodeComboBox.Name = "zipCodeComboBox";
            zipCodeComboBox.Size = new Size(73, 29);
            zipCodeComboBox.TabIndex = 22;
            zipCodeComboBox.SelectedIndexChanged += ApplyFilters;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = Color.FromArgb(243, 239, 218);
            resultsLabel.Font = new Font("Microsoft YaHei", 10.5F, FontStyle.Italic);
            resultsLabel.Location = new Point(14, 140);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(18, 24);
            resultsLabel.TabIndex = 21;
            resultsLabel.Text = "-";
            // 
            // sellerFilterLabel
            // 
            sellerFilterLabel.AutoSize = true;
            sellerFilterLabel.BackColor = Color.FromArgb(100, 131, 184);
            sellerFilterLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            sellerFilterLabel.ForeColor = Color.White;
            sellerFilterLabel.Location = new Point(153, 9);
            sellerFilterLabel.Name = "sellerFilterLabel";
            sellerFilterLabel.Size = new Size(78, 26);
            sellerFilterLabel.TabIndex = 20;
            sellerFilterLabel.Text = "Sælger";
            // 
            // soldFilterLabel
            // 
            soldFilterLabel.AutoSize = true;
            soldFilterLabel.BackColor = Color.FromArgb(100, 131, 184);
            soldFilterLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            soldFilterLabel.ForeColor = Color.White;
            soldFilterLabel.Location = new Point(14, 11);
            soldFilterLabel.Name = "soldFilterLabel";
            soldFilterLabel.Size = new Size(71, 26);
            soldFilterLabel.TabIndex = 2;
            soldFilterLabel.Text = "Status";
            // 
            // soldFilterPanel
            // 
            soldFilterPanel.BackColor = Color.FromArgb(179, 215, 232);
            soldFilterPanel.Controls.Add(soldComboBox);
            soldFilterPanel.Location = new Point(14, 36);
            soldFilterPanel.Margin = new Padding(3, 4, 3, 4);
            soldFilterPanel.Name = "soldFilterPanel";
            soldFilterPanel.Size = new Size(121, 51);
            soldFilterPanel.TabIndex = 14;
            // 
            // soldComboBox
            // 
            soldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            soldComboBox.Font = new Font("Microsoft YaHei", 10F);
            soldComboBox.FormattingEnabled = true;
            soldComboBox.Items.AddRange(new object[] { "Alle", "Solgt", "Ikke solgt" });
            soldComboBox.Location = new Point(10, 8);
            soldComboBox.Margin = new Padding(3, 4, 3, 4);
            soldComboBox.Name = "soldComboBox";
            soldComboBox.Size = new Size(100, 31);
            soldComboBox.TabIndex = 0;
            soldComboBox.SelectedIndexChanged += SoldComboBox_SelectedIndexChanged;
            // 
            // clearButtonIconLabel
            // 
            clearButtonIconLabel.BackColor = Color.PeachPuff;
            clearButtonIconLabel.BackgroundImage = Properties.Resources.ClearPropertyFiltersIcon;
            clearButtonIconLabel.BackgroundImageLayout = ImageLayout.Stretch;
            clearButtonIconLabel.Location = new Point(873, 129);
            clearButtonIconLabel.Margin = new Padding(3, 4, 3, 4);
            clearButtonIconLabel.Name = "clearButtonIconLabel";
            clearButtonIconLabel.Size = new Size(30, 36);
            clearButtonIconLabel.TabIndex = 11;
            // 
            // refreshButtonIconLabel
            // 
            refreshButtonIconLabel.BackColor = Color.FromArgb(142, 221, 188);
            refreshButtonIconLabel.BackgroundImage = Properties.Resources.Refresh_Properties_Logo;
            refreshButtonIconLabel.BackgroundImageLayout = ImageLayout.Stretch;
            refreshButtonIconLabel.Location = new Point(710, 132);
            refreshButtonIconLabel.Margin = new Padding(3, 4, 3, 4);
            refreshButtonIconLabel.Name = "refreshButtonIconLabel";
            refreshButtonIconLabel.Size = new Size(26, 31);
            refreshButtonIconLabel.TabIndex = 10;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.PeachPuff;
            clearButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            clearButton.Location = new Point(767, 119);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(146, 57);
            clearButton.TabIndex = 9;
            clearButton.Text = "Ryd filtre     ";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(148, 216, 200);
            refreshButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            refreshButton.Location = new Point(582, 119);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(167, 57);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Genindlæs    ";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += RefreshButton_Click;
            // 
            // priceFromFilterPanel
            // 
            priceFromFilterPanel.BackColor = Color.FromArgb(179, 215, 232);
            priceFromFilterPanel.Controls.Add(maxPriceTrackBar);
            priceFromFilterPanel.Controls.Add(minPriceTrackBar);
            priceFromFilterPanel.Controls.Add(selectedMaxPriceLabel);
            priceFromFilterPanel.Controls.Add(selectedMinPriceLabel);
            priceFromFilterPanel.Controls.Add(minPriceLabel);
            priceFromFilterPanel.Controls.Add(maxPriceLabel);
            priceFromFilterPanel.Location = new Point(618, 11);
            priceFromFilterPanel.Margin = new Padding(3, 4, 3, 4);
            priceFromFilterPanel.Name = "priceFromFilterPanel";
            priceFromFilterPanel.Size = new Size(295, 89);
            priceFromFilterPanel.TabIndex = 12;
            // 
            // maxPriceTrackBar
            // 
            maxPriceTrackBar.LargeChange = 0;
            maxPriceTrackBar.Location = new Point(80, 48);
            maxPriceTrackBar.Margin = new Padding(3, 4, 3, 4);
            maxPriceTrackBar.Name = "maxPriceTrackBar";
            maxPriceTrackBar.Size = new Size(119, 56);
            maxPriceTrackBar.SmallChange = 1000;
            maxPriceTrackBar.TabIndex = 3;
            maxPriceTrackBar.TickFrequency = 1000;
            maxPriceTrackBar.TickStyle = TickStyle.None;
            maxPriceTrackBar.Scroll += TrackBar_Scroll;
            maxPriceTrackBar.ValueChanged += MaxPriceTrackBar_ValueChanged;
            maxPriceTrackBar.MouseUp += MaxPriceTrackBar_MouseUp;
            // 
            // minPriceTrackBar
            // 
            minPriceTrackBar.LargeChange = 0;
            minPriceTrackBar.Location = new Point(80, 8);
            minPriceTrackBar.Margin = new Padding(3, 4, 3, 4);
            minPriceTrackBar.Name = "minPriceTrackBar";
            minPriceTrackBar.Size = new Size(119, 56);
            minPriceTrackBar.SmallChange = 1000;
            minPriceTrackBar.TabIndex = 2;
            minPriceTrackBar.TickFrequency = 1000;
            minPriceTrackBar.TickStyle = TickStyle.None;
            minPriceTrackBar.Scroll += TrackBar_Scroll;
            minPriceTrackBar.ValueChanged += MinPriceTrackBar_ValueChanged;
            minPriceTrackBar.MouseUp += MinPriceTrackBar_MouseUp;
            // 
            // selectedMaxPriceLabel
            // 
            selectedMaxPriceLabel.AutoSize = true;
            selectedMaxPriceLabel.BackColor = Color.White;
            selectedMaxPriceLabel.Font = new Font("Microsoft YaHei", 10.5F);
            selectedMaxPriceLabel.ForeColor = Color.FromArgb(38, 38, 38);
            selectedMaxPriceLabel.Location = new Point(206, 49);
            selectedMaxPriceLabel.Name = "selectedMaxPriceLabel";
            selectedMaxPriceLabel.Size = new Size(43, 24);
            selectedMaxPriceLabel.TabIndex = 7;
            selectedMaxPriceLabel.Text = "123";
            // 
            // selectedMinPriceLabel
            // 
            selectedMinPriceLabel.AutoSize = true;
            selectedMinPriceLabel.BackColor = Color.White;
            selectedMinPriceLabel.Font = new Font("Microsoft YaHei", 10.5F);
            selectedMinPriceLabel.ForeColor = Color.FromArgb(38, 38, 38);
            selectedMinPriceLabel.Location = new Point(206, 8);
            selectedMinPriceLabel.Name = "selectedMinPriceLabel";
            selectedMinPriceLabel.Size = new Size(43, 24);
            selectedMinPriceLabel.TabIndex = 6;
            selectedMinPriceLabel.Text = "123";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.BackColor = Color.FromArgb(100, 131, 184);
            minPriceLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            minPriceLabel.ForeColor = Color.White;
            minPriceLabel.Location = new Point(8, 9);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(80, 26);
            minPriceLabel.TabIndex = 4;
            minPriceLabel.Text = "Pris fra";
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.BackColor = Color.FromArgb(100, 131, 184);
            maxPriceLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            maxPriceLabel.ForeColor = Color.White;
            maxPriceLabel.Location = new Point(8, 51);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(73, 26);
            maxPriceLabel.TabIndex = 5;
            maxPriceLabel.Text = "Pris til";
            // 
            // soldDatePickerLabel
            // 
            soldDatePickerLabel.BackColor = Color.FromArgb(179, 215, 232);
            soldDatePickerLabel.Controls.Add(soldFromDatePicker);
            soldDatePickerLabel.Controls.Add(soldDateToLabel);
            soldDatePickerLabel.Controls.Add(soldDateFromLabel);
            soldDatePickerLabel.Controls.Add(soldToDatePicker);
            soldDatePickerLabel.Location = new Point(381, 11);
            soldDatePickerLabel.Margin = new Padding(3, 4, 3, 4);
            soldDatePickerLabel.Name = "soldDatePickerLabel";
            soldDatePickerLabel.Size = new Size(221, 89);
            soldDatePickerLabel.TabIndex = 17;
            soldDatePickerLabel.Visible = false;
            // 
            // soldFromDatePicker
            // 
            soldFromDatePicker.Font = new Font("Microsoft YaHei", 9.75F);
            soldFromDatePicker.Format = DateTimePickerFormat.Short;
            soldFromDatePicker.Location = new Point(96, 7);
            soldFromDatePicker.Margin = new Padding(3, 4, 3, 4);
            soldFromDatePicker.Name = "soldFromDatePicker";
            soldFromDatePicker.Size = new Size(114, 29);
            soldFromDatePicker.TabIndex = 15;
            soldFromDatePicker.Visible = false;
            soldFromDatePicker.ValueChanged += SoldFromDatePicker_ValueChanged;
            // 
            // soldDateToLabel
            // 
            soldDateToLabel.AutoSize = true;
            soldDateToLabel.BackColor = Color.FromArgb(100, 131, 184);
            soldDateToLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            soldDateToLabel.ForeColor = Color.White;
            soldDateToLabel.Location = new Point(9, 48);
            soldDateToLabel.Name = "soldDateToLabel";
            soldDateToLabel.Size = new Size(84, 26);
            soldDateToLabel.TabIndex = 18;
            soldDateToLabel.Text = "Dato til";
            soldDateToLabel.Visible = false;
            // 
            // soldDateFromLabel
            // 
            soldDateFromLabel.AutoSize = true;
            soldDateFromLabel.BackColor = Color.FromArgb(100, 131, 184);
            soldDateFromLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            soldDateFromLabel.ForeColor = Color.White;
            soldDateFromLabel.Location = new Point(9, 13);
            soldDateFromLabel.Name = "soldDateFromLabel";
            soldDateFromLabel.Size = new Size(91, 26);
            soldDateFromLabel.TabIndex = 17;
            soldDateFromLabel.Text = "Dato fra";
            soldDateFromLabel.Visible = false;
            // 
            // soldToDatePicker
            // 
            soldToDatePicker.Font = new Font("Microsoft YaHei", 9.75F);
            soldToDatePicker.Format = DateTimePickerFormat.Short;
            soldToDatePicker.Location = new Point(96, 45);
            soldToDatePicker.Margin = new Padding(3, 4, 3, 4);
            soldToDatePicker.Name = "soldToDatePicker";
            soldToDatePicker.Size = new Size(114, 29);
            soldToDatePicker.TabIndex = 16;
            soldToDatePicker.Visible = false;
            soldToDatePicker.ValueChanged += SoldToDatePicker_ValueChanged;
            // 
            // sellerComboBoxLabel
            // 
            sellerComboBoxLabel.BackColor = Color.FromArgb(179, 215, 232);
            sellerComboBoxLabel.Controls.Add(sellerComboBox);
            sellerComboBoxLabel.Location = new Point(153, 35);
            sellerComboBoxLabel.Margin = new Padding(3, 4, 3, 4);
            sellerComboBoxLabel.Name = "sellerComboBoxLabel";
            sellerComboBoxLabel.Size = new Size(113, 52);
            sellerComboBoxLabel.TabIndex = 19;
            // 
            // sellerComboBox
            // 
            sellerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sellerComboBox.Font = new Font("Microsoft YaHei", 10F);
            sellerComboBox.FormattingEnabled = true;
            sellerComboBox.Items.AddRange(new object[] { "Alle" });
            sellerComboBox.Location = new Point(7, 8);
            sellerComboBox.Margin = new Padding(3, 4, 3, 4);
            sellerComboBox.Name = "sellerComboBox";
            sellerComboBox.Size = new Size(98, 31);
            sellerComboBox.TabIndex = 18;
            sellerComboBox.SelectedValueChanged += ApplyFilters;
            // 
            // ViewPropertiesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(topPanel);
            Controls.Add(propertiesDataGridView);
            Name = "ViewPropertiesPage";
            Size = new Size(928, 603);
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchInfoPictureBox).EndInit();
            zipCodePanel.ResumeLayout(false);
            soldFilterPanel.ResumeLayout(false);
            priceFromFilterPanel.ResumeLayout(false);
            priceFromFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).EndInit();
            soldDatePickerLabel.ResumeLayout(false);
            soldDatePickerLabel.PerformLayout();
            sellerComboBoxLabel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RsDataGridView propertiesDataGridView;
        private Panel topPanel;
        private ComboBox soldComboBox;
        private TrackBar minPriceTrackBar;
        private Label minPriceLabel;
        private TrackBar maxPriceTrackBar;
        private Label maxPriceLabel;
        private Label selectedMaxPriceLabel;
        private Label selectedMinPriceLabel;
        private Button refreshButton;
        private Button clearButton;
        private Panel refreshButtonIconLabel;
        private Panel clearButtonIconLabel;
        private Panel priceFromFilterPanel;
        private Panel soldFilterPanel;
        private DateTimePicker soldToDatePicker;
        private DateTimePicker soldFromDatePicker;
        private Panel soldDatePickerLabel;
        private Label soldDateToLabel;
        private Label soldDateFromLabel;
        private Label soldFilterLabel;
        private Label sellerFilterLabel;
        private Panel sellerComboBoxLabel;
        private ComboBox sellerComboBox;
        private Label resultsLabel;
        private ComboBox zipCodeComboBox;
        private Panel zipCodePanel;
        private Label zipCodeFilterLabel;
        private Button saveToFileButton;
        private TextBox searchTextBox;
        private Label clearTextButton;
        private Button sletBolig_button;
        private PictureBox searchInfoPictureBox;
    }
}
