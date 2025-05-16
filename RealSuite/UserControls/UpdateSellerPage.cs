using Models;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdateSellerPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        public Seller? SellerToUpdate;

        public UpdateSellerPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
        }

        public void Clear() { }
    }
}
