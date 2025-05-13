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
        }

        public void Clear() { }
    }
}
