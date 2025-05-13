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
            propertiesDataGridView.DataSource = _propertyService.FilteredSortedProperties;
            SetTrackBarBounds();
            SetTrackBarInitialValues();
            soldComboBox.SelectedItem = "Alle";
        }

        private void ApplyFilters(object? sender = null, EventArgs? e = null)
        {
            string solgtFilter = soldComboBox.SelectedItem!.ToString()!;
            _propertyService.ApplyFilters(solgtFilter, minPriceTrackBar.Value, maxPriceTrackBar.Value);
            propertiesDataGridView.DataSource = _propertyService.FilteredSortedProperties;
        }

        public void Clear()
        {
            _propertyService.RefreshFromDb();
            InitializeControls();
        }

        private void SetTrackBarInitialValues()
        {
            minPriceTrackBar.Value = (int)_propertyService.FilteredSortedProperties.Min(x => x.Price);
            selectedMinPriceLabel.Text = minPriceTrackBar.Value.ToString();
            maxPriceTrackBar.Value = (int)_propertyService.FilteredSortedProperties.Max(x => x.Price);
            selectedMaxPriceLabel.Text = maxPriceTrackBar.Value.ToString();
        }

        private void SetTrackBarBounds()
        {
            minPriceTrackBar.Minimum = (int)_propertyService.FilteredSortedProperties.Min(x => x.Price);
            minPriceTrackBar.Maximum = (int)_propertyService.FilteredSortedProperties.Max(x => x.Price);
            maxPriceTrackBar.Minimum = (int)_propertyService.FilteredSortedProperties.Min(x => x.Price);
            maxPriceTrackBar.Maximum = (int)_propertyService.FilteredSortedProperties.Max(x => x.Price);
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
