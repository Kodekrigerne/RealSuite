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

            addSellerPageTimer.Enabled = true;

            tilføjButton.Enabled = false;

        }

        private void tilføjButton_Click(object sender, EventArgs e)
        {
            var sellerDTO = new SellerDTO(
                fornavnTextBox.Text,
                efternavnTextBox.Text,
                (cprNrTextBox.Text + cpr2NrTextBox.Text),
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

        private void fornavnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!fornavnTextBox.Text.Any(char.IsLetter) || fornavnTextBox.Text == "")
            {
                fornavnCheckLabel.Text = "O";
                fornavnCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                fornavnCheckLabel.Text = "P";
                fornavnCheckLabel.ForeColor = Color.Green;
            }
        }

        private void efternavnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!efternavnTextBox.Text.Any(char.IsLetter) || efternavnTextBox.Text == "")
            {
                efternavnCheckLabel.Text = "O";
                efternavnCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                efternavnCheckLabel.Text = "P";
                efternavnCheckLabel.ForeColor = Color.Green;
            }
        }

        private void cprNrTextBox_TextChanged(object sender, EventArgs e)
        {
            cpr2NrTextBox_TextChanged(sender, e);
            if (cprNrTextBox.Text.Length == cprNrTextBox.MaxLength)
            {
                cpr2NrTextBox.Focus();
            }
        }

        private void cpr2NrTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cprNrTextBox.Text.Length != 6 || !cprNrTextBox.Text.All(char.IsDigit) ||
                cpr2NrTextBox.Text.Length != 4 || !cpr2NrTextBox.Text.All(char.IsDigit))
            {
                cprCheckLabel.Text = "O";
                cprCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                cprCheckLabel.Text = "P";
                cprCheckLabel.ForeColor = Color.Green;
            }
        }

        private void vejnavnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!vejnavnTextBox.Text.Any(char.IsLetter) || vejnavnTextBox.Text == "")
            {
                vejnavnCheckLabel.Text = "O";
                vejnavnCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                vejnavnCheckLabel.Text = "P";
                vejnavnCheckLabel.ForeColor = Color.Green;
            }
        }

        private void vejNrTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!vejNrTextBox.Text.Any(char.IsDigit) || vejNrTextBox.Text == "")
            {
                vejnrCheckLabel.Text = "O";
                vejnrCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                vejnrCheckLabel.Text = "P";
                vejnrCheckLabel.ForeColor = Color.Green;
            }
        }

        private void postNrTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (postNrTextBox.Text.All(char.IsLetter) || (Convert.ToInt32(postNrTextBox.Text) < 1000 || Convert.ToInt32(postNrTextBox.Text) > 9999))
                {
                    postnrCheckLabel.Text = "O";
                    postnrCheckLabel.ForeColor = Color.Red;
                }
                else
                {
                    postnrCheckLabel.Text = "P";
                    postnrCheckLabel.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                postNrTextBox.Clear();
            }
        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {
            if (telefonTextBox.Text.Length != 8 || !telefonTextBox.Text.All(char.IsDigit))
            {
                telefonCheckLabel.Text = "O";
                telefonCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                telefonCheckLabel.Text = "P";
                telefonCheckLabel.ForeColor = Color.Green;
            }
        }

        private void addSellerPageTimer_Tick(object sender, EventArgs e)
        {
            if (fornavnCheckLabel.Text == "P" &&
                efternavnCheckLabel.Text == "P" &&
                cprCheckLabel.Text == "P" &&
                vejnavnCheckLabel.Text == "P" &&
                vejnrCheckLabel.Text == "P" &&
                postnrCheckLabel.Text == "P" &&
                telefonCheckLabel.Text == "P"
               )
            {
                tilføjButton.Enabled = true;
            }
            else tilføjButton.Enabled = false;
        }
    }
}
