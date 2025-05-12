using RealSuite.UserControls;

namespace RealSuite
{
    public partial class MainForm : Form
    {
        private Dictionary<string, UserControl> _pages = [];

        public MainForm()
        {
            InitializeComponent();
            InitializePages();
            _pages["front"].Visible = true;
        }

        private void InitializePages()
        {
            _pages = new Dictionary<string, UserControl>
            {
                {"front", new FrontPage() },
                {"addProperty", new AddPropertyPage() },
                {"viewProperties", new ViewPropertiesPage() },
                {"updateProperty", new UpdatePropertyPage() },
                {"addSeller", new AddSellerPage() },
                {"viewSellers", new ViewSellersPage() },
                {"updateSeller", new UpdateSellerPage() },
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

        private void NavigateTo(string pageKey)
        {
            if (!_pages.ContainsKey(pageKey)) throw new ArgumentException(nameof(pageKey));

            foreach (var page in _pages)
            {
                page.Value.Visible = false;
            }
            _pages[pageKey].Visible = true;
            _pages[pageKey].Focus();
        }
    }
}
