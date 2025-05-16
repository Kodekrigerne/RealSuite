using Models;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdateSellerPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        public Seller? SellerToUpdate;

        public UpdateSellerPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
            SetupPage();
        }

        public void SetupSellerDetails()
        {
            if (SellerToUpdate != null)
            {
                kundeIdTextBox.Text = SellerToUpdate.Id.ToString();
                fornavnTextBox.Text = SellerToUpdate.FirstName;
                efternavnTextBox.Text = SellerToUpdate.LastName;
                cprNrTextBox.Text = SellerToUpdate.CprNumber.Substring(0, 6);
                cpr2NrTextBox.Text = SellerToUpdate.CprNumber.Substring(6, 4);
                vejnavnTextBox.Text = SellerToUpdate.StreetName;
                vejNrTextBox.Text = SellerToUpdate.StreetNumber.ToString();
                postNrTextBox.Text = SellerToUpdate.ZipCode.ToString();
                telefonTextBox.Text = SellerToUpdate.PhoneNumber;
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
    }
}

