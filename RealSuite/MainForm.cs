using BusinessLogic;
using RealSuite.Enums;
using RealSuite.Events;
using RealSuite.Services;
using RealSuite.UserControls;

namespace RealSuite
{
    public partial class MainForm : Form
    {
        private Dictionary<Pages, UserControl> _pages = [];
        private readonly NavigationService _navigation;

        private readonly StatusService _statusService = new();

        public MainForm()
        {
            InitializeComponent();
            InitializePages();
            _navigation = new(_pages);
            _navigation.NavigateTo(Pages.Front);
            if (_pages[Pages.ViewProperties] is ViewPropertiesPage viewPropertiesPage) viewPropertiesPage.RowDoubleClick += HandleUpdateProperty;
            if (_pages[Pages.ViewSellers] is ViewSellersPage viewSellersPage) viewSellersPage.RowDoubleClick += HandleUpdateSeller;
            CheckServerStatus();
        }

        private void InitializePages()
        {
            _pages = new Dictionary<Pages, UserControl>
            {
                {Pages.Front, new FrontPage(_navigation) },
                {Pages.AddProperty, new AddPropertyPage(_navigation) },
                {Pages.ViewProperties, new ViewPropertiesPage(_navigation) },
                {Pages.UpdateProperty, new UpdatePropertyPage(_navigation) },
                {Pages.AddSeller, new AddSellerPage(_navigation) },
                {Pages.ViewSellers, new ViewSellersPage(_navigation) },
                {Pages.UpdateSeller, new UpdateSellerPage(_navigation) },
            };
            foreach (var page in _pages)
            {
                PageSetup(page.Value);
            }
        }

        private void PageSetup(UserControl page)
        {
            page.Visible = false;
            page.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(page);
        }

        private void HandleUpdateProperty(object? sender, UpdatePropertyEventArgs e)
        {
            var page = _pages[Pages.UpdateProperty];
            if (page is UpdatePropertyPage updatePropertyPage)
            {
                updatePropertyPage.PropertyToUpdate = e.Property;
                updatePropertyPage.SetupPageDetails();
            }

            _navigation.NavigateTo(Pages.UpdateProperty);
        }

        private void HandleUpdateSeller(object? sender, UpdateSellerEventArgs e)
        {
            var page = _pages[Pages.UpdateSeller];
            if (page is UpdateSellerPage updateSellerPage)
            {
                updateSellerPage.SellerToUpdate = e.Seller;
            }

            _navigation.NavigateTo(Pages.UpdateSeller);
        }

        private void HighlightButton(object sender, EventArgs e)
        {
            if (sender is Button button) button.BackColor = ColorTranslator.FromHtml("#9BB7ED");
        }

        private void StopHighlightButton(object sender, EventArgs e)
        {
            if (sender is Button button) button.BackColor = ColorTranslator.FromHtml("#79A0EB");
        }

        private void HighlightClickButton(object sender, EventArgs e)
        {
            if (sender is Button button) button.BackColor = ColorTranslator.FromHtml("#B3C8EF");
        }

        private void ViewPropertiesButton_Click(object sender, EventArgs e)
        {
            _navigation.NavigateTo(Pages.ViewProperties);
        }

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            _navigation.NavigateTo(Pages.AddProperty);
        }

        private void ViewSellersButton_Click(object sender, EventArgs e)
        {
            _navigation.NavigateTo(Pages.ViewSellers);
        }

        private void LogoPanel_Click(object sender, EventArgs e)
        {
            _navigation.NavigateTo(Pages.Front);
        }

        private void AddSellerButton_Click(object sender, EventArgs e)
        {
            _navigation.NavigateTo(Pages.AddSeller);
        }

        private void SetLogo(Bitmap bitmap)
        {
            LogoPanel.BackgroundImage = bitmap;
            LogoPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LogoPanel_MouseEnter(object sender, EventArgs e)
        {
            SetLogo(Properties.Resources.FrontLogoHighlight);
        }

        private void LogoPanel_MouseLeave(object sender, EventArgs e)
        {
            SetLogo(Properties.Resources.FrontLogo);
        }

        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            SetLogo(Properties.Resources.FrontLogoClick);
        }

        private void LogoPanel_MouseUp(object sender, MouseEventArgs e)
        {
            SetLogo(Properties.Resources.FrontLogoHighlight);
        }

        private void CheckServerStatus()
        {
            serverIndicatorLabel.ForeColor = _statusService.DbCheck() ? Color.LightGreen : Color.Red;
        }

        private void DbCheckTimer_Tick(object sender, EventArgs e)
        {
            CheckServerStatus();
        }
    }
}
