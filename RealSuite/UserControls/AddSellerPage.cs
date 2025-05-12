using BusinessLogic;
using Models.DTOModels;

namespace RealSuite.UserControls
{
    public partial class AddSellerPage : UserControl
    {
        SellerService sellerService = new SellerService();

        public AddSellerPage()
        {
            InitializeComponent();

        }

        private void tilføjButton_Click(object sender, EventArgs e)
        {
            var sellerDTO = new SellerDTO(
                fornavnTextBox.Text,
                efternavnTextBox.Text,
                cprNrTextBox.Text,
                vejnavnTextBox.Text,
                Convert.ToInt32(vejNrTextBox.Text),
                Convert.ToInt32(postNrTextBox.Text),
                telefonTextBox.Text);

            bool rowsAffected = sellerService.CreateSellerDTO(sellerDTO);

            if (rowsAffected == true)
            {
                MessageBox.Show("Sælger oprettet i databasen.", "Sælger oprettet");
            }
            else
            {
                MessageBox.Show("Sælger ikke oprettet i database", "Fejl under oprettelse");
            }
        }
    }
}
