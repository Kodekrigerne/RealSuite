using RealSuite.Enums;
using RealSuite.UserControls;

namespace RealSuite
{
    public partial class MainForm : Form
    {
        private Dictionary<Pages, UserControl> _pages = [];

        public MainForm()
        {
            InitializeComponent();
            InitializePages();
            _pages[Pages.Front].Visible = true;
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
            if (!_pages.ContainsKey(pageKey)) throw new ArgumentException(nameof(pageKey));

            foreach (var page in _pages)
            {
                page.Value.Visible = false;
            }
            _pages[pageKey].Visible = true;
            _pages[pageKey].Focus();
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

        private void LogoPanel_MouseEnter(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Properties.Resources.FrontLogoHighlight;
            LogoPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LogoPanel_MouseLeave(object sender, EventArgs e)
        {
            LogoPanel.BackgroundImage = Properties.Resources.FrontLogo;
            LogoPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LogoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LogoPanel.BackgroundImage = Properties.Resources.FrontLogoClick;
            LogoPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void LogoPanel_MouseUp(object sender, MouseEventArgs e)
        {
            LogoPanel.BackgroundImage = Properties.Resources.FrontLogoHighlight;
            LogoPanel.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
