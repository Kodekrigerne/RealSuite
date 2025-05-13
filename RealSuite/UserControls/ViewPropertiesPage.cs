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
        }

        private void ApplyFilters()
        {
            string solgtFilter = solgtComboBox.SelectedItem!.ToString()!;
            _propertyService.ApplyFilters(solgtFilter);
            propertiesDataGridView.DataSource = _propertyService.FilteredSortedProperties;
        }

        public void Clear() { }

        private void SolgtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
