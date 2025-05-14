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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            propertiesDataGridView = new DataGridView();
            propertyServiceBindingSource = new BindingSource(components);
            topPanel = new Panel();
            label3 = new Label();
            minPriceLabel = new Label();
            maxPriceLabel = new Label();
            soldLabel = new Label();
            panel5 = new Panel();
            soldComboBox = new ComboBox();
            panel2 = new Panel();
            panel1 = new Panel();
            clearButton = new Button();
            refreshButton = new Button();
            panel3 = new Panel();
            minPriceTrackBar = new TrackBar();
            selectedMinPriceLabel = new Label();
            panel4 = new Panel();
            maxPriceTrackBar = new TrackBar();
            selectedMaxPriceLabel = new Label();
            panel6 = new Panel();
            listedFromDatePicker = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            listedToDatePicker = new DateTimePicker();
            panel7 = new Panel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).BeginInit();
            topPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // propertiesDataGridView
            // 
            propertiesDataGridView.AllowUserToAddRows = false;
            propertiesDataGridView.AllowUserToDeleteRows = false;
            propertiesDataGridView.AllowUserToOrderColumns = true;
            propertiesDataGridView.AllowUserToResizeColumns = false;
            propertiesDataGridView.AllowUserToResizeRows = false;
            propertiesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            propertiesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            propertiesDataGridView.BackgroundColor = Color.White;
            propertiesDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            propertiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            propertiesDataGridView.ColumnHeadersHeight = 35;
            propertiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(228, 221, 177);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            propertiesDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            propertiesDataGridView.Dock = DockStyle.Bottom;
            propertiesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            propertiesDataGridView.EnableHeadersVisualStyles = false;
            propertiesDataGridView.GridColor = Color.Gainsboro;
            propertiesDataGridView.Location = new Point(0, 190);
            propertiesDataGridView.Margin = new Padding(3, 4, 3, 4);
            propertiesDataGridView.Name = "propertiesDataGridView";
            propertiesDataGridView.RowHeadersVisible = false;
            propertiesDataGridView.RowHeadersWidth = 51;
            propertiesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            propertiesDataGridView.Size = new Size(928, 413);
            propertiesDataGridView.TabIndex = 0;
            propertiesDataGridView.TabStop = false;
            // 
            // propertyServiceBindingSource
            // 
            propertyServiceBindingSource.DataSource = typeof(BusinessLogic.PropertyService);
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(228, 221, 177);
            topPanel.Controls.Add(label3);
            topPanel.Controls.Add(minPriceLabel);
            topPanel.Controls.Add(maxPriceLabel);
            topPanel.Controls.Add(soldLabel);
            topPanel.Controls.Add(panel5);
            topPanel.Controls.Add(panel2);
            topPanel.Controls.Add(panel1);
            topPanel.Controls.Add(clearButton);
            topPanel.Controls.Add(refreshButton);
            topPanel.Controls.Add(panel3);
            topPanel.Controls.Add(panel4);
            topPanel.Controls.Add(panel6);
            topPanel.Controls.Add(panel7);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(3, 4, 3, 4);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(928, 181);
            topPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(158, 126, 97);
            label3.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(153, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 26);
            label3.TabIndex = 20;
            label3.Text = "Sælger";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.BackColor = Color.FromArgb(158, 126, 97);
            minPriceLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            minPriceLabel.ForeColor = Color.White;
            minPriceLabel.Location = new Point(283, 9);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(80, 26);
            minPriceLabel.TabIndex = 4;
            minPriceLabel.Text = "Pris fra";
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.BackColor = Color.FromArgb(158, 126, 97);
            maxPriceLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            maxPriceLabel.ForeColor = Color.White;
            maxPriceLabel.Location = new Point(410, 11);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(73, 26);
            maxPriceLabel.TabIndex = 5;
            maxPriceLabel.Text = "Pris til";
            // 
            // soldLabel
            // 
            soldLabel.AutoSize = true;
            soldLabel.BackColor = Color.FromArgb(158, 126, 97);
            soldLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            soldLabel.ForeColor = Color.White;
            soldLabel.Location = new Point(14, 11);
            soldLabel.Name = "soldLabel";
            soldLabel.Size = new Size(71, 26);
            soldLabel.TabIndex = 2;
            soldLabel.Text = "Status";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(79, 117, 184);
            panel5.Controls.Add(soldComboBox);
            panel5.Location = new Point(14, 36);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(121, 51);
            panel5.TabIndex = 14;
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
            soldComboBox.SelectedIndexChanged += ApplyFilters;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BackgroundImage = Properties.Resources.ClearPropertyFiltersIcon;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(873, 129);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 36);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(185, 223, 240);
            panel1.BackgroundImage = Properties.Resources.Refresh_Properties_Logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(710, 132);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(26, 31);
            panel1.TabIndex = 10;
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
            refreshButton.BackColor = Color.FromArgb(185, 223, 240);
            refreshButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            refreshButton.Location = new Point(582, 119);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(167, 57);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Genindlæs    ";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += RefreshButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(79, 117, 184);
            panel3.Controls.Add(minPriceTrackBar);
            panel3.Controls.Add(selectedMinPriceLabel);
            panel3.Location = new Point(283, 35);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 80);
            panel3.TabIndex = 12;
            // 
            // minPriceTrackBar
            // 
            minPriceTrackBar.LargeChange = 0;
            minPriceTrackBar.Location = new Point(-3, 44);
            minPriceTrackBar.Margin = new Padding(3, 4, 3, 4);
            minPriceTrackBar.Name = "minPriceTrackBar";
            minPriceTrackBar.Size = new Size(119, 56);
            minPriceTrackBar.SmallChange = 1000;
            minPriceTrackBar.TabIndex = 2;
            minPriceTrackBar.TickFrequency = 1000;
            minPriceTrackBar.TickStyle = TickStyle.None;
            minPriceTrackBar.ValueChanged += MinPriceTrackBar_ValueChanged;
            minPriceTrackBar.MouseUp += MinPriceTrackBar_MouseUp;
            // 
            // selectedMinPriceLabel
            // 
            selectedMinPriceLabel.AutoSize = true;
            selectedMinPriceLabel.BackColor = Color.White;
            selectedMinPriceLabel.Font = new Font("Microsoft YaHei", 10.5F);
            selectedMinPriceLabel.ForeColor = Color.FromArgb(38, 38, 38);
            selectedMinPriceLabel.Location = new Point(6, 9);
            selectedMinPriceLabel.Name = "selectedMinPriceLabel";
            selectedMinPriceLabel.Size = new Size(43, 24);
            selectedMinPriceLabel.TabIndex = 6;
            selectedMinPriceLabel.Text = "123";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(79, 117, 184);
            panel4.Controls.Add(maxPriceTrackBar);
            panel4.Controls.Add(selectedMaxPriceLabel);
            panel4.Location = new Point(410, 36);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(122, 80);
            panel4.TabIndex = 13;
            // 
            // maxPriceTrackBar
            // 
            maxPriceTrackBar.LargeChange = 0;
            maxPriceTrackBar.Location = new Point(0, 43);
            maxPriceTrackBar.Margin = new Padding(3, 4, 3, 4);
            maxPriceTrackBar.Name = "maxPriceTrackBar";
            maxPriceTrackBar.Size = new Size(119, 56);
            maxPriceTrackBar.SmallChange = 1000;
            maxPriceTrackBar.TabIndex = 3;
            maxPriceTrackBar.TickFrequency = 1000;
            maxPriceTrackBar.TickStyle = TickStyle.None;
            maxPriceTrackBar.ValueChanged += MaxPriceTrackBar_ValueChanged;
            maxPriceTrackBar.MouseUp += MaxPriceTrackBar_MouseUp;
            // 
            // selectedMaxPriceLabel
            // 
            selectedMaxPriceLabel.AutoSize = true;
            selectedMaxPriceLabel.BackColor = Color.White;
            selectedMaxPriceLabel.Font = new Font("Microsoft YaHei", 10.5F);
            selectedMaxPriceLabel.ForeColor = Color.FromArgb(38, 38, 38);
            selectedMaxPriceLabel.Location = new Point(10, 8);
            selectedMaxPriceLabel.Name = "selectedMaxPriceLabel";
            selectedMaxPriceLabel.Size = new Size(43, 24);
            selectedMaxPriceLabel.TabIndex = 7;
            selectedMaxPriceLabel.Text = "123";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(79, 117, 184);
            panel6.Controls.Add(listedFromDatePicker);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(listedToDatePicker);
            panel6.Location = new Point(616, 11);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(297, 89);
            panel6.TabIndex = 17;
            // 
            // listedFromDatePicker
            // 
            listedFromDatePicker.Font = new Font("Microsoft YaHei", 9.75F);
            listedFromDatePicker.Format = DateTimePickerFormat.Short;
            listedFromDatePicker.Location = new Point(96, 7);
            listedFromDatePicker.Margin = new Padding(3, 4, 3, 4);
            listedFromDatePicker.Name = "listedFromDatePicker";
            listedFromDatePicker.Size = new Size(191, 29);
            listedFromDatePicker.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(84, 26);
            label2.TabIndex = 18;
            label2.Text = "Dato til";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(91, 26);
            label1.TabIndex = 17;
            label1.Text = "Dato fra";
            // 
            // listedToDatePicker
            // 
            listedToDatePicker.Font = new Font("Microsoft YaHei", 9.75F);
            listedToDatePicker.Format = DateTimePickerFormat.Short;
            listedToDatePicker.Location = new Point(96, 45);
            listedToDatePicker.Margin = new Padding(3, 4, 3, 4);
            listedToDatePicker.Name = "listedToDatePicker";
            listedToDatePicker.Size = new Size(191, 29);
            listedToDatePicker.TabIndex = 16;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(79, 117, 184);
            panel7.Controls.Add(comboBox1);
            panel7.Location = new Point(153, 35);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(113, 52);
            panel7.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft YaHei", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(7, 8);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(98, 31);
            comboBox1.TabIndex = 18;
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
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView propertiesDataGridView;
        private BindingSource propertyServiceBindingSource;
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DateTimePicker listedToDatePicker;
        private DateTimePicker listedFromDatePicker;
        private Panel panel6;
        private Label label2;
        private Label label1;
        private Label soldLabel;
        private Label label3;
        private Panel panel7;
        private ComboBox comboBox1;
    }
}
