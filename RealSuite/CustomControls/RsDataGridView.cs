using System.ComponentModel;

namespace RealSuite.CustomControls
{
    public class RsDataGridView : DataGridView
    {
        [DefaultValue(false)]
        public new bool AllowUserToAddRows
        {
            get => base.AllowUserToAddRows;
            set => base.AllowUserToAddRows = value;
        }

        [DefaultValue(false)]
        public new bool AllowUserToDeleteRows
        {
            get => base.AllowUserToDeleteRows;
            set => base.AllowUserToDeleteRows = value;
        }

        [DefaultValue(false)]
        public new bool AllowUserToOrderColumns
        {
            get => base.AllowUserToOrderColumns;
            set => base.AllowUserToOrderColumns = value;
        }

        [DefaultValue(false)]
        public new bool AllowUserToResizeColumns
        {
            get => base.AllowUserToResizeColumns;
            set => base.AllowUserToResizeColumns = value;
        }

        [DefaultValue(false)]
        public new bool AllowUserToResizeRows
        {
            get => base.AllowUserToResizeRows;
            set => base.AllowUserToResizeRows = value;
        }

        [DefaultValue(DataGridViewAutoSizeColumnsMode.AllCells)]
        public new DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode
        {
            get => base.AutoSizeColumnsMode;
            set => base.AutoSizeColumnsMode = value;
        }

        [DefaultValue(DataGridViewAutoSizeRowsMode.AllCells)]
        public new DataGridViewAutoSizeRowsMode AutoSizeRowsMode
        {
            get => base.AutoSizeRowsMode;
            set => base.AutoSizeRowsMode = value;
        }

        [DefaultValue(typeof(Color), "White")]
        public new Color BackgroundColor
        {
            get => base.BackgroundColor;
            set => base.BackgroundColor = value;
        }

        [DefaultValue(DataGridViewCellBorderStyle.SingleVertical)]
        public new DataGridViewCellBorderStyle CellBorderStyle
        {
            get => base.CellBorderStyle;
            set => base.CellBorderStyle = value;
        }

        [DefaultValue(35)]
        public new int ColumnHeadersHeight
        {
            get => base.ColumnHeadersHeight;
            set => base.ColumnHeadersHeight = value;
        }

        [DefaultValue(DataGridViewColumnHeadersHeightSizeMode.DisableResizing)]
        public new DataGridViewColumnHeadersHeightSizeMode ColumnHeadersHeightSizeMode
        {
            get => base.ColumnHeadersHeightSizeMode;
            set => base.ColumnHeadersHeightSizeMode = value;
        }

        [DefaultValue(DockStyle.Bottom)]
        public new DockStyle Dock
        {
            get => base.Dock;
            set => base.Dock = value;
        }

        [DefaultValue(DataGridViewEditMode.EditProgrammatically)]
        public new DataGridViewEditMode EditMode
        {
            get => base.EditMode;
            set => base.EditMode = value;
        }

        [DefaultValue(false)]
        public new bool EnableHeadersVisualStyles
        {
            get => base.EnableHeadersVisualStyles;
            set => base.EnableHeadersVisualStyles = value;
        }

        [DefaultValue(typeof(Color), "Gainsboro")]
        public new Color GridColor
        {
            get => base.GridColor;
            set => base.GridColor = value;
        }

        [DefaultValue(false)]
        public new bool MultiSelect
        {
            get => base.MultiSelect;
            set => base.MultiSelect = value;
        }

        [DefaultValue(false)]
        public new bool RowHeadersVisible
        {
            get => base.RowHeadersVisible;
            set => base.RowHeadersVisible = value;
        }

        [DefaultValue(51)]
        public new int RowHeadersWidth
        {
            get => base.RowHeadersWidth;
            set => base.RowHeadersWidth = value;
        }

        [DefaultValue(DataGridViewSelectionMode.FullRowSelect)]
        public new DataGridViewSelectionMode SelectionMode
        {
            get => base.SelectionMode;
            set => base.SelectionMode = value;
        }

        [DefaultValue(false)]
        public new bool TabStop
        {
            get => base.TabStop;
            set => base.TabStop = value;
        }

        public RsDataGridView()
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BackgroundColor = Color.White;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            ColumnHeadersHeight = 35;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Dock = DockStyle.Bottom;
            EditMode = DataGridViewEditMode.EditProgrammatically;
            EnableHeadersVisualStyles = false;
            GridColor = Color.Gainsboro;
            MultiSelect = false;
            RowHeadersVisible = false;
            RowHeadersWidth = 51;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabStop = false;

            var alternatingRowsDefaultCellStyle = new DataGridViewCellStyle()
            {
                NullValue = null
            };

            var columnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(166, 193, 239),
                Font = new Font("Microsoft YaHei", 11F, FontStyle.Bold),
                ForeColor = SystemColors.WindowText,
                SelectionBackColor = Color.FromArgb(166, 193, 239),
                SelectionForeColor = SystemColors.ControlText,
                WrapMode = DataGridViewTriState.True,
            };

            var defaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                BackColor = SystemColors.Window,
                Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = SystemColors.ControlText,
                NullValue = null,
                SelectionBackColor = Color.FromArgb(228, 221, 177),
                SelectionForeColor = SystemColors.Desktop,
                WrapMode = DataGridViewTriState.False,
            };

            AlternatingRowsDefaultCellStyle = alternatingRowsDefaultCellStyle;
            ColumnHeadersDefaultCellStyle = columnHeadersDefaultCellStyle;
            DefaultCellStyle = defaultCellStyle;
        }
    }
}
