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
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            solgtLabel = new Label();
            solgtComboBox = new ComboBox();
            panel2 = new Panel();
            maxPriceLabel = new Label();
            selectedMaxPriceLabel = new Label();
            minPriceLabel = new Label();
            selectedMinPriceLabel = new Label();
            minPriceTrackBar = new TrackBar();
            maxPriceTrackBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).BeginInit();
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
            propertiesDataGridView.Location = new Point(0, 142);
            propertiesDataGridView.Name = "propertiesDataGridView";
            propertiesDataGridView.RowHeadersVisible = false;
            propertiesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            propertiesDataGridView.Size = new Size(812, 310);
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
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 145);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.For_Sale_Icon;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(88, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 26);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(207, 191, 143);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(solgtLabel);
            panel3.Controls.Add(solgtComboBox);
            panel3.Location = new Point(16, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 76);
            panel3.TabIndex = 9;
            // 
            // solgtLabel
            // 
            solgtLabel.AutoSize = true;
            solgtLabel.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            solgtLabel.ForeColor = Color.White;
            solgtLabel.Location = new Point(10, 11);
            solgtLabel.Name = "solgtLabel";
            solgtLabel.Size = new Size(56, 19);
            solgtLabel.TabIndex = 1;
            solgtLabel.Text = "Status";
            // 
            // solgtComboBox
            // 
            solgtComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            solgtComboBox.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            solgtComboBox.FormattingEnabled = true;
            solgtComboBox.Items.AddRange(new object[] { "Alle", "Solgt", "Ikke solgt" });
            solgtComboBox.Location = new Point(10, 35);
            solgtComboBox.Name = "solgtComboBox";
            solgtComboBox.Size = new Size(106, 29);
            solgtComboBox.TabIndex = 0;
            solgtComboBox.SelectedIndexChanged += SolgtComboBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(207, 191, 143);
            panel2.Controls.Add(maxPriceLabel);
            panel2.Controls.Add(selectedMaxPriceLabel);
            panel2.Controls.Add(minPriceLabel);
            panel2.Controls.Add(selectedMinPriceLabel);
            panel2.Controls.Add(minPriceTrackBar);
            panel2.Controls.Add(maxPriceTrackBar);
            panel2.Location = new Point(157, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 96);
            panel2.TabIndex = 8;
            // 
            // maxPriceLabel
            // 
            maxPriceLabel.AutoSize = true;
            maxPriceLabel.BackColor = Color.FromArgb(232, 225, 182);
            maxPriceLabel.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            maxPriceLabel.ForeColor = Color.White;
            maxPriceLabel.Location = new Point(156, 6);
            maxPriceLabel.Name = "maxPriceLabel";
            maxPriceLabel.Size = new Size(58, 19);
            maxPriceLabel.TabIndex = 5;
            maxPriceLabel.Text = "Pris til:";
            // 
            // selectedMaxPriceLabel
            // 
            selectedMaxPriceLabel.AutoSize = true;
            selectedMaxPriceLabel.BackColor = Color.Transparent;
            selectedMaxPriceLabel.Font = new Font("Microsoft YaHei", 11.25F);
            selectedMaxPriceLabel.ForeColor = Color.White;
            selectedMaxPriceLabel.Location = new Point(156, 31);
            selectedMaxPriceLabel.Name = "selectedMaxPriceLabel";
            selectedMaxPriceLabel.Size = new Size(46, 20);
            selectedMaxPriceLabel.TabIndex = 7;
            selectedMaxPriceLabel.Text = "price";
            // 
            // minPriceLabel
            // 
            minPriceLabel.AutoSize = true;
            minPriceLabel.BackColor = Color.FromArgb(232, 225, 182);
            minPriceLabel.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold);
            minPriceLabel.ForeColor = Color.White;
            minPriceLabel.Location = new Point(8, 6);
            minPriceLabel.Name = "minPriceLabel";
            minPriceLabel.Size = new Size(65, 19);
            minPriceLabel.TabIndex = 4;
            minPriceLabel.Text = "Pris fra:";
            // 
            // selectedMinPriceLabel
            // 
            selectedMinPriceLabel.AutoSize = true;
            selectedMinPriceLabel.BackColor = Color.Transparent;
            selectedMinPriceLabel.Font = new Font("Microsoft YaHei", 11.25F);
            selectedMinPriceLabel.ForeColor = Color.White;
            selectedMinPriceLabel.Location = new Point(8, 31);
            selectedMinPriceLabel.Name = "selectedMinPriceLabel";
            selectedMinPriceLabel.Size = new Size(46, 20);
            selectedMinPriceLabel.TabIndex = 6;
            selectedMinPriceLabel.Text = "price";
            // 
            // minPriceTrackBar
            // 
            minPriceTrackBar.LargeChange = 0;
            minPriceTrackBar.Location = new Point(3, 59);
            minPriceTrackBar.Name = "minPriceTrackBar";
            minPriceTrackBar.Size = new Size(125, 45);
            minPriceTrackBar.SmallChange = 1000;
            minPriceTrackBar.TabIndex = 2;
            minPriceTrackBar.TickFrequency = 1000;
            minPriceTrackBar.TickStyle = TickStyle.None;
            minPriceTrackBar.ValueChanged += MinPriceTrackBar_ValueChanged;
            minPriceTrackBar.MouseUp += MinPriceTrackBar_MouseUp;
            // 
            // maxPriceTrackBar
            // 
            maxPriceTrackBar.LargeChange = 0;
            maxPriceTrackBar.Location = new Point(148, 59);
            maxPriceTrackBar.Name = "maxPriceTrackBar";
            maxPriceTrackBar.Size = new Size(125, 45);
            maxPriceTrackBar.SmallChange = 1000;
            maxPriceTrackBar.TabIndex = 3;
            maxPriceTrackBar.TickFrequency = 1000;
            maxPriceTrackBar.TickStyle = TickStyle.None;
            maxPriceTrackBar.ValueChanged += MaxPriceTrackBar_ValueChanged;
            maxPriceTrackBar.MouseUp += MaxPriceTrackBar_MouseUp;
            // 
            // ViewPropertiesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(propertiesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewPropertiesPage";
            Size = new Size(812, 452);
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minPriceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxPriceTrackBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView propertiesDataGridView;
        private BindingSource propertyServiceBindingSource;
        private Panel panel1;
        private ComboBox solgtComboBox;
        private Label solgtLabel;
        private Panel panel2;
        private Label maxPriceLabel;
        private Label selectedMaxPriceLabel;
        private Label minPriceLabel;
        private Label selectedMinPriceLabel;
        private TrackBar minPriceTrackBar;
        private TrackBar maxPriceTrackBar;
        private Panel panel4;
        private Panel panel3;
    }
}
