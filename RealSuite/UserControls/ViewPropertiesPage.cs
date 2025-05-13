using System.Diagnostics;
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
            propertiesDataGridView.DataSource = _propertyService.FilteredSortedProperties;
            solgtComboBox.SelectedItem = "Alle";
            minPriceTrackBar.Value = (int)_propertyService.FilteredSortedProperties.Min(x => x.Price);
            selectedMinPriceLabel.Text = minPriceTrackBar.Value.ToString();
            maxPriceTrackBar.Value = (int)_propertyService.FilteredSortedProperties.Max(x => x.Price);
            selectedMaxPriceLabel.Text = maxPriceTrackBar.Value.ToString();
        }

        private void ApplyFilters()
        {
            string solgtFilter = solgtComboBox.SelectedItem!.ToString()!;
            _propertyService.ApplyFilters(solgtFilter, minPriceTrackBar.Value, maxPriceTrackBar.Value);
            minPriceTrackBar.Minimum = (int)_propertyService.FilteredSortedProperties.Min(x => x.Price);
            minPriceTrackBar.Maximum = (int)_propertyService.FilteredSortedProperties.Max(x => x.Price);
            maxPriceTrackBar.Minimum = (int)_propertyService.FilteredSortedProperties.Min(x => x.Price);
            maxPriceTrackBar.Maximum = (int)_propertyService.FilteredSortedProperties.Max(x => x.Price);
            propertiesDataGridView.DataSource = _propertyService.FilteredSortedProperties;

        }

        public void Clear() { }

        private void SolgtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
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
            ApplyFilters();
        }

        private void MaxPriceTrackBar_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
