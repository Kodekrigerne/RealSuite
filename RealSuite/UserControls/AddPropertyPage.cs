using BusinessLogic;
using RealSuite.Interfaces;

namespace RealSuite.UserControls
{
    public partial class AddPropertyPage : UserControl, IClearable
    {
        private SellerService sellerService = new SellerService();

        public AddPropertyPage()
        {
            InitializeComponent();

            addSellerGrid.Visible = false;
            var sellerDataTable = sellerService.GetSellers();
            addSellerGrid.DataSource = sellerDataTable;
            addSellerGrid.Columns[0].HeaderText = "Kunde ID";
            addSellerGrid.Columns[1].HeaderText = "Fornavn";
            addSellerGrid.Columns[2].HeaderText = "Efternavn";
            addSellerGrid.Columns[3].Visible = false;
            addSellerGrid.Columns[4].Visible = false;
            addSellerGrid.Columns[5].Visible = false;
            addSellerGrid.Columns[6].Visible = false;
            addSellerGrid.Columns[7].HeaderText = "Telefon";



        }

        public void Clear() { }

        private void addSellerButton_Click(object sender, EventArgs e)
        {
            addSellerGrid.Visible = true;
        }

        private void addSellerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addSellerGrid.Visible = false;
        }
    }
}
