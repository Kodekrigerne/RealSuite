using BusinessLogic;
using RealSuite.Enums;
using RealSuite.Interfaces;
using RealSuite.UserControls;

namespace RealSuite
{
    public partial class MainForm : Form
    {
        private Dictionary<Pages, UserControl> _pages = [];
        private UserControl _currentPage;

        StatusService _statusService = new StatusService();

        public MainForm()
        {
            InitializeComponent();
            InitializePages();
            _currentPage = _pages[Pages.Front];
            NavigateTo(Pages.Front);
            CheckServerStatus();
        }

        private void InitializePages()
        {
            _pages = new Dictionary<Pages, UserControl>
            {
                {Pages.Front, new FrontPage() },
                {Pages.AddProperty, new AddPropertyPage() },
                {Pages.ViewProperties, new ViewPropertiesPage() },
                {Pages.UpdateProperty, new UpdatePropertyPage() },
                {Pages.AddSeller, new AddSellerPage() },
                {Pages.ViewSellers, new ViewSellersPage() },
                {Pages.UpdateSellers, new UpdateSellerPage() },
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

        private void NavigateTo(Pages pageKey)
        {
            if (_currentPage != _pages[pageKey])
            {
                if (!_pages.TryGetValue(pageKey, out var page)) throw new ArgumentException("No page assigned to: ", nameof(pageKey));

                if (_pages[pageKey] is IClearable clearablePage) clearablePage.Clear();

                foreach (var otherPage in _pages)
                {
                    if (otherPage.Value != page) otherPage.Value.Visible = false;
                }

                page.Visible = true;
                page.Focus();
                _currentPage = page;
            }
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
            NavigateTo(Pages.ViewProperties);
        }

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {
            NavigateTo(Pages.AddProperty);
        }

        private void ViewSellersButton_Click(object sender, EventArgs e)
        {
            NavigateTo(Pages.ViewSellers);
        }

        private void LogoPanel_Click(object sender, EventArgs e)
        {
            NavigateTo(Pages.Front);
        }

        private void AddSellerButton_Click(object sender, EventArgs e)
        {
            NavigateTo(Pages.AddSeller);
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

        private void dbCheckTimer_Tick(object sender, EventArgs e)
        {
            CheckServerStatus();
        }
    }
}
