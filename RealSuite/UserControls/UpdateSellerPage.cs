using System.Text.RegularExpressions;
using Models;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdateSellerPage : UserControl, IClearable, INavigatable
    {
        private NavigationService? _navigation;
        public Seller? SellerToUpdate;

        public UpdateSellerPage()
        {
            InitializeComponent();
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
            SetupPage();
        }

        public void SetupSellerDetails()
        {
            if (SellerToUpdate != null)
            {
                DisableEventHandlers();

                kundeIdTextBox.Text = SellerToUpdate.Id.ToString();
                fornavnTextBox.Text = SellerToUpdate.FirstName;
                efternavnTextBox.Text = SellerToUpdate.LastName;
                cprNrTextBox.Text = SellerToUpdate.CprNumber.Substring(0, 6);
                cpr2NrTextBox.Text = SellerToUpdate.CprNumber.Substring(6, 4);
                vejnavnTextBox.Text = SellerToUpdate.StreetName;
                vejNrTextBox.Text = SellerToUpdate.StreetNumber.ToString();
                postNrTextBox.Text = SellerToUpdate.ZipCode.ToString();
                telefonTextBox.Text = SellerToUpdate.PhoneNumber;

                EnableEventHandlers();
            }
        }

        public void SetupPage()
        {
            kundeIdTextBox.Enabled = false;
            fornavnTextBox.Enabled = false;
            efternavnTextBox.Enabled = false;
            cprNrTextBox.Enabled = false;
            cpr2NrTextBox.Enabled = false;
            vejnavnTextBox.Enabled = false;
            vejNrTextBox.Enabled = false;
            postNrTextBox.Enabled = false;
            telefonTextBox.Enabled = false;
            redigering_checkbox.Checked = false;
            fortrydButton.Visible = false;
            bekræftButton.Visible = false;

            CheckLabelsVisibility(false);
        }

        public void EnablePageEdit()
        {
            fornavnTextBox.Enabled = true;
            efternavnTextBox.Enabled = true;
            cprNrTextBox.Enabled = true;
            cpr2NrTextBox.Enabled = true;
            vejnavnTextBox.Enabled = true;
            vejNrTextBox.Enabled = true;
            postNrTextBox.Enabled = true;
            telefonTextBox.Enabled = true;
            fortrydButton.Visible = true;
            bekræftButton.Visible = true;
        }

        public void Clear()
        {
            redigering_checkbox.Checked = false;
        }

        private void redigering_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (redigering_checkbox.Checked)
            {
                DialogResult confirm = MessageBox.Show("Aktivér redigering?",
                    "Bekræft redigering", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    {
                        EnablePageEdit();
                    }
                }
                else if (confirm == DialogResult.No)
                {
                    redigering_checkbox.Checked = false;
                }
            }
            else if (SellerDataChanged())
            {
                DialogResult confirm =
                    MessageBox.Show(
                        "Ændringer er ikke gemt. Hvis du fortsætter, vil ændringer blive slettet. Ønsker du at fortsætte?",
                        "Ændringer ej gemt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    SetupPage();
                    SetupSellerDetails();
                }
                else
                {
                    UpdateCheckBoxNoHandler(true);
                }
            }
            else
            {
                SetupPage();
                SetupSellerDetails();
            }
        }

        private void fortrydButton_Click(object sender, EventArgs e)
        {
            SetupSellerDetails();
        }

        private bool SellerDataChanged()
        {
            if (kundeIdTextBox.Text != SellerToUpdate.Id.ToString() ||
                fornavnTextBox.Text != SellerToUpdate.FirstName ||
                efternavnTextBox.Text != SellerToUpdate.LastName ||
                cprNrTextBox.Text != SellerToUpdate.CprNumber.Substring(0, 6) ||
                cpr2NrTextBox.Text != SellerToUpdate.CprNumber.Substring(6, 4) ||
                vejnavnTextBox.Text != SellerToUpdate.StreetName ||
                vejNrTextBox.Text != SellerToUpdate.StreetNumber.ToString() ||
                postNrTextBox.Text != SellerToUpdate.ZipCode.ToString() ||
                telefonTextBox.Text != SellerToUpdate.PhoneNumber) return true;
            return false;
        }

        private void UpdateCheckBoxNoHandler(bool status)
        {
            redigering_checkbox.CheckedChanged -= redigering_checkbox_CheckedChanged;
            redigering_checkbox.Checked = status;
            redigering_checkbox.CheckedChanged += redigering_checkbox_CheckedChanged;
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

            ConfirmButtonCheck();
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

            ConfirmButtonCheck();
        }

        private void cprNrTextBox_TextChanged(object sender, EventArgs e)
        {
            cprCheckLabel.Visible = true;
            cpr2NrTextBox_TextChanged(sender, e);

            if (cprNrTextBox.Text.Length == cprNrTextBox.MaxLength)
            {
                cpr2NrTextBox.Focus();
            }

            ConfirmButtonCheck();
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

            ConfirmButtonCheck();
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

            ConfirmButtonCheck();
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

            ConfirmButtonCheck();
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

            ConfirmButtonCheck();
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

            ConfirmButtonCheck();
        }

        private void DisableEventHandlers()
        {
            fornavnTextBox.TextChanged -= fornavnTextBox_TextChanged;
            efternavnTextBox.TextChanged -= efternavnTextBox_TextChanged;
            cprNrTextBox.TextChanged -= cprNrTextBox_TextChanged;
            cpr2NrTextBox.TextChanged -= cpr2NrTextBox_TextChanged;
            vejnavnTextBox.TextChanged -= vejnavnTextBox_TextChanged;
            vejNrTextBox.TextChanged -= vejNrTextBox_TextChanged;
            postNrTextBox.TextChanged -= postNrTextBox_TextChanged;
            telefonTextBox.TextChanged -= telefonTextBox_TextChanged;
        }

        private void EnableEventHandlers()
        {
            fornavnTextBox.TextChanged += fornavnTextBox_TextChanged;
            efternavnTextBox.TextChanged += efternavnTextBox_TextChanged;
            cprNrTextBox.TextChanged += cprNrTextBox_TextChanged;
            cpr2NrTextBox.TextChanged += cpr2NrTextBox_TextChanged;
            vejnavnTextBox.TextChanged += vejnavnTextBox_TextChanged;
            vejNrTextBox.TextChanged += vejNrTextBox_TextChanged;
            postNrTextBox.TextChanged += postNrTextBox_TextChanged;
            telefonTextBox.TextChanged += telefonTextBox_TextChanged;
        }

        private void ConfirmButtonCheck()
        {
            if (fornavnCheckLabel.Text == "O" ||
                efternavnCheckLabel.Text == "O" ||
                cprCheckLabel.Text == "O" ||
                vejnavnCheckLabel.Text == "O" ||
                vejnrCheckLabel.Text == "O" ||
                postnrCheckLabel.Text == "O" ||
                telefonCheckLabel.Text == "O"
               )
            {
                bekræftButton.Enabled = false;
            }
            else
            {
                bekræftButton.Enabled = true;
            }

        }

        private void CheckLabelsVisibility(bool status)
        {
            fornavnCheckLabel.Visible = status;
            efternavnCheckLabel.Visible = status;
            cprCheckLabel.Visible = status;
            vejnavnCheckLabel.Visible = status;
            vejnrCheckLabel.Visible = status;
            postnrCheckLabel.Visible = status;
            telefonCheckLabel.Visible = status;
        }
    }
}

