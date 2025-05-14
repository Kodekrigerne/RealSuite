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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(166, 193, 239);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            propertiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            propertiesDataGridView.ColumnHeadersHeight = 35;
            propertiesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 221, 177);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            propertiesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            propertiesDataGridView.Dock = DockStyle.Bottom;
            propertiesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            propertiesDataGridView.EnableHeadersVisualStyles = false;
            propertiesDataGridView.GridColor = Color.Gainsboro;
            propertiesDataGridView.Location = new Point(0, 142);
            propertiesDataGridView.Name = "propertiesDataGridView";
            propertiesDataGridView.RowHeadersVisible = false;
            propertiesDataGridView.RowHeadersWidth = 51;
            propertiesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            propertiesDataGridView.Size = new Size(812, 310);
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
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(812, 136);
            topPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(158, 126, 97);
            label3.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(134, 7);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 20;
            label3.Text = "Sælger";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.BackColor = Color.FromArgb(158, 126, 97);
            minPriceLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            minPriceLabel.ForeColor = Color.White;
            minPriceLabel.Location = new Point(248, 7);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(61, 19);
            minPriceLabel.TabIndex = 4;
            minPriceLabel.Text = "Pris fra";
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.BackColor = Color.FromArgb(158, 126, 97);
            maxPriceLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            maxPriceLabel.ForeColor = Color.White;
            maxPriceLabel.Location = new Point(359, 8);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(54, 19);
            maxPriceLabel.TabIndex = 5;
            maxPriceLabel.Text = "Pris til";
            // 
            // soldLabel
            // 
            soldLabel.AutoSize = true;
            soldLabel.BackColor = Color.FromArgb(158, 126, 97);
            soldLabel.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            soldLabel.ForeColor = Color.White;
            soldLabel.Location = new Point(12, 8);
            soldLabel.Name = "soldLabel";
            soldLabel.Size = new Size(56, 19);
            soldLabel.TabIndex = 2;
            soldLabel.Text = "Status";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(79, 117, 184);
            panel5.Controls.Add(soldComboBox);
            panel5.Location = new Point(12, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(106, 38);
            panel5.TabIndex = 14;
            // 
            // soldComboBox
            // 
            soldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            soldComboBox.Font = new Font("Microsoft YaHei", 10F);
            soldComboBox.FormattingEnabled = true;
            soldComboBox.Items.AddRange(new object[] { "Alle", "Solgt", "Ikke solgt" });
            soldComboBox.Location = new Point(9, 6);
            soldComboBox.Name = "soldComboBox";
            soldComboBox.Size = new Size(88, 27);
            soldComboBox.TabIndex = 0;
            soldComboBox.SelectedIndexChanged += ApplyFilters;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BackgroundImage = Properties.Resources.ClearPropertyFiltersIcon;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(764, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(26, 27);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(185, 223, 240);
            panel1.BackgroundImage = Properties.Resources.Refresh_Properties_Logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(621, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(23, 23);
            panel1.TabIndex = 10;
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
            clearButton.Click += ClearButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(185, 223, 240);
            refreshButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            refreshButton.Location = new Point(509, 89);
            refreshButton.Margin = new Padding(3, 2, 3, 2);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(146, 43);
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
            panel3.Location = new Point(248, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(105, 60);
            panel3.TabIndex = 12;
            // 
            // minPriceTrackBar
            // 
            minPriceTrackBar.LargeChange = 0;
            minPriceTrackBar.Location = new Point(-3, 33);
            minPriceTrackBar.Name = "minPriceTrackBar";
            minPriceTrackBar.Size = new Size(104, 45);
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
            selectedMinPriceLabel.Location = new Point(5, 7);
            selectedMinPriceLabel.Name = "selectedMinPriceLabel";
            selectedMinPriceLabel.Size = new Size(33, 20);
            selectedMinPriceLabel.TabIndex = 6;
            selectedMinPriceLabel.Text = "123";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(79, 117, 184);
            panel4.Controls.Add(maxPriceTrackBar);
            panel4.Controls.Add(selectedMaxPriceLabel);
            panel4.Location = new Point(359, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(107, 60);
            panel4.TabIndex = 13;
            // 
            // maxPriceTrackBar
            // 
            maxPriceTrackBar.LargeChange = 0;
            maxPriceTrackBar.Location = new Point(0, 32);
            maxPriceTrackBar.Name = "maxPriceTrackBar";
            maxPriceTrackBar.Size = new Size(104, 45);
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
            selectedMaxPriceLabel.Location = new Point(9, 6);
            selectedMaxPriceLabel.Name = "selectedMaxPriceLabel";
            selectedMaxPriceLabel.Size = new Size(33, 20);
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
            panel6.Location = new Point(606, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(193, 67);
            panel6.TabIndex = 17;
            // 
            // listedFromDatePicker
            // 
            listedFromDatePicker.Font = new Font("Microsoft YaHei", 9.75F);
            listedFromDatePicker.Format = DateTimePickerFormat.Short;
            listedFromDatePicker.Location = new Point(84, 5);
            listedFromDatePicker.Name = "listedFromDatePicker";
            listedFromDatePicker.Size = new Size(100, 25);
            listedFromDatePicker.TabIndex = 15;
            listedFromDatePicker.ValueChanged += listedFromDatePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 36);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 18;
            label2.Text = "Dato til";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 17;
            label1.Text = "Dato fra";
            // 
            // listedToDatePicker
            // 
            listedToDatePicker.Font = new Font("Microsoft YaHei", 9.75F);
            listedToDatePicker.Format = DateTimePickerFormat.Short;
            listedToDatePicker.Location = new Point(84, 34);
            listedToDatePicker.Name = "listedToDatePicker";
            listedToDatePicker.Size = new Size(100, 25);
            listedToDatePicker.TabIndex = 16;
            listedToDatePicker.ValueChanged += ListedToDatePicker_ValueChanged;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(79, 117, 184);
            panel7.Controls.Add(comboBox1);
            panel7.Location = new Point(134, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(99, 39);
            panel7.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft YaHei", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 27);
            comboBox1.TabIndex = 18;
            // 
            // ViewPropertiesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(topPanel);
            Controls.Add(propertiesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewPropertiesPage";
            Size = new Size(812, 452);
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
