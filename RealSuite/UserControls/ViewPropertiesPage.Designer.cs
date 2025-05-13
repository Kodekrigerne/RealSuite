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
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).BeginInit();
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
            propertiesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            propertiesDataGridView.Size = new Size(812, 310);
            propertiesDataGridView.TabIndex = 0;
            propertiesDataGridView.TabStop = false;
            // 
            // propertyServiceBindingSource
            // 
            propertyServiceBindingSource.DataSource = typeof(BusinessLogic.PropertyService);
            // 
            // ViewPropertiesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(propertiesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewPropertiesPage";
            Size = new Size(812, 452);
            ((System.ComponentModel.ISupportInitialize)propertiesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)propertyServiceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView propertiesDataGridView;
        private BindingSource propertyServiceBindingSource;
    }
}
