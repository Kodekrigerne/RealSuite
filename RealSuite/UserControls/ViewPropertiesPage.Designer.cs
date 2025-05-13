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
            panel1 = new Panel();
            refreshButton = new Button();
            selectedMaxPriceLabel = new Label();
            selectedMinPriceLabel = new Label();
            maxPriceLabel = new Label();
            minPriceLabel = new Label();
            maxPriceTrackBar = new TrackBar();
            minPriceTrackBar = new TrackBar();
            solgtLabel = new Label();
            solgtComboBox = new ComboBox();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 221, 177);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(refreshButton);
            panel1.Controls.Add(selectedMaxPriceLabel);
            panel1.Controls.Add(selectedMinPriceLabel);
            panel1.Controls.Add(maxPriceLabel);
            panel1.Controls.Add(minPriceLabel);
            panel1.Controls.Add(maxPriceTrackBar);
            panel1.Controls.Add(minPriceTrackBar);
            panel1.Controls.Add(solgtLabel);
            panel1.Controls.Add(solgtComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 193);
            panel1.TabIndex = 1;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(829, 154);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(94, 29);
            refreshButton.TabIndex = 8;
            refreshButton.Text = "Genindlæs";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // selectedMaxPriceLabel
            // 
            selectedMaxPriceLabel.AutoSize = true;
            selectedMaxPriceLabel.Location = new Point(471, 19);
            selectedMaxPriceLabel.Name = "selectedMaxPriceLabel";
            selectedMaxPriceLabel.Size = new Size(0, 20);
            selectedMaxPriceLabel.TabIndex = 7;
            // 
            // selectedMinPriceLabel
            // 
            selectedMinPriceLabel.AutoSize = true;
            selectedMinPriceLabel.Location = new Point(302, 19);
            selectedMinPriceLabel.Name = "selectedMinPriceLabel";
            selectedMinPriceLabel.Size = new Size(0, 20);
            selectedMinPriceLabel.TabIndex = 6;
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.Location = new Point(401, 19);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(49, 20);
            maxPriceLabel.TabIndex = 5;
            maxPriceLabel.Text = "Pris til";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.Location = new Point(232, 19);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(54, 20);
            minPriceLabel.TabIndex = 4;
            minPriceLabel.Text = "Pris fra";
            // 
            // maxPriceTrackBar
            // 
            maxPriceTrackBar.LargeChange = 0;
            maxPriceTrackBar.Location = new Point(401, 43);
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
            // minPriceTrackBar
            // 
            minPriceTrackBar.LargeChange = 0;
            minPriceTrackBar.Location = new Point(232, 43);
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
            // solgtLabel
            // 
            solgtLabel.AutoSize = true;
            solgtLabel.Location = new Point(30, 19);
            solgtLabel.Name = "solgtLabel";
            solgtLabel.Size = new Size(44, 20);
            solgtLabel.TabIndex = 1;
            solgtLabel.Text = "Solgt";
            // 
            // solgtComboBox
            // 
            solgtComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            solgtComboBox.FormattingEnabled = true;
            solgtComboBox.Items.AddRange(new object[] { "Alle", "Solgt", "Ikke solgt" });
            solgtComboBox.Location = new Point(30, 43);
            solgtComboBox.Margin = new Padding(3, 4, 3, 4);
            solgtComboBox.Name = "solgtComboBox";
            solgtComboBox.Size = new Size(121, 28);
            solgtComboBox.TabIndex = 0;
            solgtComboBox.SelectedIndexChanged += ApplyFilters;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(729, 154);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 9;
            clearButton.Text = "Ryd filtre";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // ViewPropertiesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(propertiesDataGridView);
            Name = "ViewPropertiesPage";
            Size = new Size(928, 603);
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView propertiesDataGridView;
        private BindingSource propertyServiceBindingSource;
        private Panel panel1;
        private ComboBox solgtComboBox;
        private Label solgtLabel;
        private TrackBar minPriceTrackBar;
        private Label minPriceLabel;
        private TrackBar maxPriceTrackBar;
        private Label maxPriceLabel;
        private Label selectedMaxPriceLabel;
        private Label selectedMinPriceLabel;
        private Button refreshButton;
        private Button clearButton;
    }
}
