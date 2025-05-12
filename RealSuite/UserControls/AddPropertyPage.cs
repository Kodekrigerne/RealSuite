using RealSuite.Interfaces;

namespace RealSuite.UserControls
{
    public partial class AddPropertyPage : UserControl, IClearable
    {
        public AddPropertyPage()
        {
            InitializeComponent();
        }

        public void Clear() { }
    }
}
