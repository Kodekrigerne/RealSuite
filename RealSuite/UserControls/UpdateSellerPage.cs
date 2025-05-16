using Models;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdateSellerPage : UserControl, IClearable, INavigatable
    {
        private NavigationService? _navigation;
        public Seller? SellerToUpdate;

        public UpdateSellerPage()
        {
            InitializeComponent();
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
        }

        public void Clear() { }
    }
}
