using Models;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdatePropertyPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        public Property? UpdateProperty;

        public UpdatePropertyPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
        }

        public void Clear() { }
    }
}
