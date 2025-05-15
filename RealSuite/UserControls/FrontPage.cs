using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class FrontPage : UserControl
    {
        private readonly NavigationService _navigation;

        public FrontPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
        }
    }
}
