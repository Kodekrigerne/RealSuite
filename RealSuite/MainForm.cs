using RealSuite.UserControls;

namespace RealSuite
{
    public partial class MainForm : Form
    {
        private readonly FrontPage _frontPage = new();
        private readonly AddSellerPage _addSellerPage = new();
        private readonly AddPropertyPage _addPropertyPage = new();
        private readonly ViewPropertiesPage _viewPropertiesPage = new();
        private readonly ViewSellersPage _viewSellersPage = new();
        private readonly UpdatePropertyPage _updatePropertyPage = new();
        private readonly UpdateSellerPage _updateSellerPage = new();

        public MainForm()
        {
            InitializeComponent();
            InitializePages();
            _frontPage.Visible = true;
        }

        private void InitializePages()
        {
            PageSetup(_frontPage);
            PageSetup(_addSellerPage);
            PageSetup(_addPropertyPage);
            PageSetup(_viewPropertiesPage);
            PageSetup(_viewSellersPage);
            PageSetup(_updatePropertyPage);
            PageSetup(_updateSellerPage);
        }

        private void PageSetup(UserControl page)
        {
            page.Visible = false;
            page.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(page);
        }
    }
}
