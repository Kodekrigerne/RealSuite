using RealSuite.Enums;
using RealSuite.Interfaces;

namespace RealSuite.Services
{
    public class NavigationService
    {
        public Dictionary<Pages, UserControl> Pages { get; }
        private UserControl _currentPage;

        public NavigationService(Dictionary<Pages, UserControl> pages)
        {
            Pages = pages;
            _currentPage = pages[Enums.Pages.Front];
            _currentPage.Visible = true;
        }

        public void NavigateTo(Pages pageKey) { NavigateTo(pageKey, true); }

        public void NavigateTo(Pages pageKey, bool clear)
        {
            if (_currentPage != Pages[pageKey])
            {
                if (!Pages.TryGetValue(pageKey, out var page)) throw new ArgumentException("No page assigned to: ", nameof(pageKey));


                foreach (var otherPage in Pages)
                {
                    if (otherPage.Value != page) otherPage.Value.Visible = false;
                }

                page.Visible = true;
                page.Focus();
                if (clear && Pages[pageKey] is IClearable clearablePage) clearablePage.Clear();
                _currentPage = page;
            }
        }
    }
}
