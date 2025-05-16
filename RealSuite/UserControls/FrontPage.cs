using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class FrontPage : UserControl, INavigatable
    {
        private NavigationService? _navigation;

        public FrontPage()
        {
            InitializeComponent();
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
        }
    }
}
