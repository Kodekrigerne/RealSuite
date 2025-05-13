namespace RealSuite.UserControls
{
    partial class AddPropertyPage
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
            label1 = new Label();
            addSellerGrid = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            addSellerButton = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 224);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "viewproperties :) :3";
            // 
            // addSellerGrid
            // 
            addSellerGrid.AllowUserToAddRows = false;
            addSellerGrid.AllowUserToDeleteRows = false;
            addSellerGrid.AllowUserToResizeColumns = false;
            addSellerGrid.AllowUserToResizeRows = false;
            addSellerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            addSellerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            addSellerGrid.Location = new Point(397, 29);
            addSellerGrid.MultiSelect = false;
            addSellerGrid.Name = "addSellerGrid";
            addSellerGrid.ReadOnly = true;
            addSellerGrid.RowHeadersVisible = false;
            addSellerGrid.RowHeadersWidth = 51;
            addSellerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            addSellerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addSellerGrid.Size = new Size(502, 491);
            addSellerGrid.TabIndex = 1;
            addSellerGrid.UseWaitCursor = true;
            addSellerGrid.CellDoubleClick += addSellerGrid_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // addSellerButton
            // 
            addSellerButton.Location = new Point(534, 547);
            addSellerButton.Name = "addSellerButton";
            addSellerButton.Size = new Size(120, 29);
            addSellerButton.TabIndex = 2;
            addSellerButton.Text = "Tilføj sælger";
            addSellerButton.UseVisualStyleBackColor = true;
            addSellerButton.Click += addSellerButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 149);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // AddPropertyPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(addSellerButton);
            Controls.Add(addSellerGrid);
            Controls.Add(label1);
            Name = "AddPropertyPage";
            Size = new Size(928, 603);
            ((System.ComponentModel.ISupportInitialize)addSellerGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView addSellerGrid;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button addSellerButton;
        private TextBox textBox1;
    }
}
