using System.Text.RegularExpressions;
using BusinessLogic;
using Models.DTOModels;

using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class AddSellerPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        SellerService sellerService = new SellerService();

        public AddSellerPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;

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

            bool rowCreated = sellerService.CreateSellerDTO(sellerDTO);

            if (rowCreated == true)
            {
                MessageBox.Show("Sælger oprettet i databasen.", "Sælger oprettet");
                Clear();
                fornavnTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Sælger ikke oprettet i database", "Fejl under oprettelse");
            }
        }

        private void fornavnTextBox_TextChanged(object sender, EventArgs e)
        {
            fornavnCheckLabel.Visible = true;
            if (!fornavnTextBox.Text.All(char.IsLetter) || fornavnTextBox.Text == "")
            {
                fornavnCheckLabel.Text = "O";
                fornavnCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                fornavnCheckLabel.Text = "P";
                fornavnCheckLabel.ForeColor = Color.Green;
            }

            SubmitKeyCheck();
        }

        private void efternavnTextBox_TextChanged(object sender, EventArgs e)
        {
            efternavnCheckLabel.Visible = true;
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

            SubmitKeyCheck();
        }

        private void cprNrTextBox_TextChanged(object sender, EventArgs e)
        {
            cprCheckLabel.Visible = true;
            cpr2NrTextBox_TextChanged(sender, e);

            if (cprNrTextBox.Text.Length == cprNrTextBox.MaxLength)
            {
                cpr2NrTextBox.Focus();
            }

            SubmitKeyCheck();
        }

        private void cpr2NrTextBox_TextChanged(object sender, EventArgs e)
        {
            cprCheckLabel.Visible = true;
            if (cpr2NrTextBox.Text.Length == 0)
            {
                cprNrTextBox.Focus();
            }

            if (cprNrTextBox.Text.Length != 6 || !cprNrTextBox.Text.All(char.IsDigit) ||
                cpr2NrTextBox.Text.Length != 4 || !cpr2NrTextBox.Text.All(char.IsDigit) ||
                !Regex.IsMatch(cprNrTextBox.Text, @"^(?:0[1-9]|[12]\d|3[01])(?:0[1-9]|1[0-2])(?:[0-9]{2})$"))
            {
                cprCheckLabel.Text = "O";
                cprCheckLabel.ForeColor = Color.Red;
            }
            else
            {
                cprCheckLabel.Text = "P";
                cprCheckLabel.ForeColor = Color.Green;
            }

            SubmitKeyCheck();
        }

        private void vejnavnTextBox_TextChanged(object sender, EventArgs e)
        {
            vejnavnCheckLabel.Visible = true;
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

            SubmitKeyCheck();
        }

        private void vejNrTextBox_TextChanged(object sender, EventArgs e)
        {
            vejnrCheckLabel.Visible = true;
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

            SubmitKeyCheck();
        }

        private void postNrTextBox_TextChanged(object sender, EventArgs e)
        {
            postnrCheckLabel.Visible = true;

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

            SubmitKeyCheck();
        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e)
        {
            telefonCheckLabel.Visible = true;
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

            SubmitKeyCheck();
        }

        public void Clear()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Label label && label.Font.Name == "Wingdings 2")
                {
                    label.Visible = false;
                }
            }
        }

        private void HandleDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void HandleLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void SubmitKeyCheck()
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
            else
            {
                tilføjButton.Enabled = false;
            }

        }

        private void rydButton_Click(object sender, EventArgs e)
        {
            Clear();
            fornavnTextBox.Focus();
        }
    }
}
