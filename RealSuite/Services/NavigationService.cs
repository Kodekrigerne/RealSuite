using RealSuite.Enums;
using RealSuite.Interfaces;

namespace RealSuite.Services
{
    public class NavigationService
    {
        private readonly Dictionary<Pages, UserControl> _pages;
        private UserControl _currentPage;

        public NavigationService(Dictionary<Pages, UserControl> pages)
        {
            _pages = pages;
            _currentPage = pages[Pages.Front];
            _currentPage.Visible = true;
        }

        public void NavigateTo(Pages pageKey) { NavigateTo(pageKey, true); }

        public void NavigateTo(Pages pageKey, bool clear)
        {
            if (_currentPage != _pages[pageKey])
            {
                if (!_pages.TryGetValue(pageKey, out var page)) throw new ArgumentException("No page assigned to: ", nameof(pageKey));


                foreach (var otherPage in _pages)
                {
                    if (otherPage.Value != page) otherPage.Value.Visible = false;
                }

                page.Visible = true;
                page.Focus();
                if (clear && _currentPage is IClearable clearablePage) clearablePage.Clear();
                _currentPage = page;
            }
        }
    }
}
