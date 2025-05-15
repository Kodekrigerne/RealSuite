using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class ViewSellersPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;

        public ViewSellersPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
        }

        public void Clear() { }
    }
}
