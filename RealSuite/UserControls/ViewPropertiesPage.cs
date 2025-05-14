using System.Data;
using BusinessLogic;
using RealSuite.Interfaces;

namespace RealSuite.UserControls
{
    public partial class ViewPropertiesPage : UserControl, IClearable
    {
        private readonly PropertyService _propertyService = new();
        public ViewPropertiesPage()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            propertiesDataGridView.DataSource = _propertyService.PropertiesSource;
            SetTrackBarBounds();
            SetTrackBarInitialValues();
            soldComboBox.SelectedItem = "Alle";
        }

        private void ApplyFilters(object? sender = null, EventArgs? e = null)
        {
            string solgtFilter = soldComboBox.SelectedItem!.ToString()!;
            _propertyService.ApplyFilters(solgtFilter, minPriceTrackBar.Value, maxPriceTrackBar.Value);
            propertiesDataGridView.DataSource = _propertyService.PropertiesSource;
        }

        public void Clear()
        {
            _propertyService.RefreshFromDb();
            InitializeControls();
        }

        private void SetTrackBarInitialValues()
        {
            minPriceTrackBar.Value = minPriceTrackBar.Minimum;
            selectedMinPriceLabel.Text = minPriceTrackBar.Value.ToString();
            maxPriceTrackBar.Value = maxPriceTrackBar.Maximum;
            selectedMaxPriceLabel.Text = maxPriceTrackBar.Value.ToString();
        }

        private void SetTrackBarBounds()
        {
            var table = ((DataTable)_propertyService.PropertiesSource.DataSource).AsEnumerable();

            int minPrice;
            int maxPrice;
            try
            {
                minPrice = (int)table.Min(x => x.Field<Decimal>("Price"));
                maxPrice = (int)table.Max(x => x.Field<Decimal>("Price"));
            }
            catch
            {
                minPrice = 0;
                maxPrice = 1000;
            }

            minPriceTrackBar.Minimum = minPrice;
            minPriceTrackBar.Maximum = maxPrice;
            maxPriceTrackBar.Minimum = minPrice;
            maxPriceTrackBar.Maximum = maxPrice;
        }

        private void MinPriceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            selectedMinPriceLabel.Text = minPriceTrackBar.Value.ToString();
        }

        private void MaxPriceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            selectedMaxPriceLabel.Text = maxPriceTrackBar.Value.ToString();
        }

        private void MinPriceTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (minPriceTrackBar.Value > maxPriceTrackBar.Value) minPriceTrackBar.Value = maxPriceTrackBar.Value;
            ApplyFilters();
        }

        private void MaxPriceTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (maxPriceTrackBar.Value < minPriceTrackBar.Value) maxPriceTrackBar.Value = minPriceTrackBar.Value;
            ApplyFilters();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _propertyService.RefreshFromDb();
            ApplyFilters();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
