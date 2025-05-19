using System.Text.RegularExpressions;
using BusinessLogic;
using Models;
using RealSuite.Enums;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class UpdateSellerPage : UserControl, IClearable, INavigatable
    {
        private NavigationService? _navigation;
        private SellerService sellerService = new SellerService();
        public Seller? SellerToUpdate;

        public UpdateSellerPage()
        {
            InitializeComponent();
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
        }

        public void SetupPage()
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

                redigering_checkbox.Checked = false;

                PageEdit(false);

                CheckLabelsText("");

                SetupListedPropertiesGrid();
                SetupSoldPropertiesGrid();
            }
        }

        public void PageEdit(bool status)
        {
            fornavnTextBox.Enabled = status;
            efternavnTextBox.Enabled = status;
            cprNrTextBox.Enabled = status;
            cpr2NrTextBox.Enabled = status;
            vejnavnTextBox.Enabled = status;
            vejNrTextBox.Enabled = status;
            postNrTextBox.Enabled = status;
            telefonTextBox.Enabled = status;
            fortrydButton.Visible = status;
            bekræftButton.Visible = status;
            deleteButton.Visible = status;
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
                        PageEdit(true);
                        ConfirmButtonCheck();
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
                }
                else
                {
                    UpdateCheckBoxNoHandler(true);
                }
            }
            else
            {
                SetupPage();
            }
        }

        private void fortrydButton_Click(object sender, EventArgs e)
        {
            fornavnTextBox.Text = SellerToUpdate.FirstName;
            efternavnTextBox.Text = SellerToUpdate.LastName;
            cprNrTextBox.Text = SellerToUpdate.CprNumber.Substring(0, 6);
            cpr2NrTextBox.Text = SellerToUpdate.CprNumber.Substring(6, 4);
            vejnavnTextBox.Text = SellerToUpdate.StreetName;
            vejNrTextBox.Text = SellerToUpdate.StreetNumber.ToString();
            postNrTextBox.Text = SellerToUpdate.ZipCode.ToString();
            telefonTextBox.Text = SellerToUpdate.PhoneNumber;
            CheckLabelsText("");
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
            if (fornavnTextBox.Text == SellerToUpdate.FirstName)
            {
                fornavnCheckLabel.Text = string.Empty;
            }
            else if (!fornavnTextBox.Text.All(char.IsLetter) || fornavnTextBox.Text == "")
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
            if (efternavnTextBox.Text == SellerToUpdate.LastName)
            {
                efternavnCheckLabel.Text = string.Empty;
            }
            else if (!efternavnTextBox.Text.Any(char.IsLetter) || efternavnTextBox.Text == "")
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
            cpr2NrTextBox_TextChanged(sender, e);

            if (cprNrTextBox.Text.Length == cprNrTextBox.MaxLength)
            {
                cpr2NrTextBox.Focus();
            }

            ConfirmButtonCheck();
        }

        private void cpr2NrTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cpr2NrTextBox.Text.Length == 0)
            {
                cprNrTextBox.Focus();
            }

            if (cprNrTextBox.Text == SellerToUpdate.CprNumber.Substring(0, 6) &&
                cpr2NrTextBox.Text == SellerToUpdate.CprNumber.Substring(6, 4))
            {
                cprCheckLabel.Text = string.Empty;
            }
            else if (cprNrTextBox.Text.Length != 6 || !cprNrTextBox.Text.All(char.IsDigit) ||
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
            if (vejnavnTextBox.Text == SellerToUpdate.StreetName)
            {
                vejnavnCheckLabel.Text = string.Empty;
            }
            else if (!vejnavnTextBox.Text.Any(char.IsLetter) || vejnavnTextBox.Text == "")
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
            if (vejNrTextBox.Text == SellerToUpdate.StreetNumber.ToString())
            {
                vejnrCheckLabel.Text = string.Empty;
            }
            else if (!vejNrTextBox.Text.Any(char.IsDigit) || vejNrTextBox.Text == "")
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
            try
            {
                if (postNrTextBox.Text == SellerToUpdate.ZipCode.ToString())
                {
                    postnrCheckLabel.Text = string.Empty;
                }
                else if (postNrTextBox.Text.All(char.IsLetter) || (Convert.ToInt32(postNrTextBox.Text) < 1000 || Convert.ToInt32(postNrTextBox.Text) > 9999))
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
            if (telefonTextBox.Text == SellerToUpdate.PhoneNumber)
            {
                telefonCheckLabel.Text = string.Empty;
            }
            else if (telefonTextBox.Text.Length != 8 || !telefonTextBox.Text.All(char.IsDigit))
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
                telefonCheckLabel.Text == "O" ||
                SellerDataChanged() == false
               )
            {
                bekræftButton.Enabled = false;
            }
            else
            {
                bekræftButton.Enabled = true;
            }

        }

        private void CheckLabelsText(string text)
        {
            fornavnCheckLabel.Text = text;
            efternavnCheckLabel.Text = text;
            cprCheckLabel.Text = text;
            vejnavnCheckLabel.Text = text;
            vejnrCheckLabel.Text = text;
            postnrCheckLabel.Text = text;
            telefonCheckLabel.Text = text;
        }

        private void SetupSoldPropertiesGrid()
        {
            if (SellerToUpdate != null)
            {
                soldPropertiesDataGrid.DataSource = sellerService.SellerSoldProperties(SellerToUpdate);

                new List<int> { 0, 4, 5, 6, 8, 9, 11, 12 }.ForEach(columnIndex =>
                    soldPropertiesDataGrid.Columns[columnIndex].Visible = false);

                soldPropertiesDataGrid.Columns[1].HeaderText = "Vej";
                soldPropertiesDataGrid.Columns[2].HeaderText = "Nr.";
                soldPropertiesDataGrid.Columns[3].HeaderText = "Postnr.";
                soldPropertiesDataGrid.Columns[7].HeaderText = "Pris.";
                soldPropertiesDataGrid.Columns[10].HeaderText = "Solgt";
            }
        }

        private void SetupListedPropertiesGrid()
        {
            if (SellerToUpdate != null)
            {
                listedPropertiesDataGrid.DataSource = sellerService.SellerListedProperties(SellerToUpdate);

                new List<int> { 0, 4, 5, 6, 8, 10, 11, 12 }.ForEach(columnIndex =>
                    listedPropertiesDataGrid.Columns[columnIndex].Visible = false);

                listedPropertiesDataGrid.Columns[1].HeaderText = "Vej";
                listedPropertiesDataGrid.Columns[2].HeaderText = "Nr.";
                listedPropertiesDataGrid.Columns[3].HeaderText = "Postnr.";
                listedPropertiesDataGrid.Columns[7].HeaderText = "Pris.";
                listedPropertiesDataGrid.Columns[9].HeaderText = "Sat til salg";
            }
        }

        private void sellerDataGrids_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            DataGridView dataGridView = sender as DataGridView;
            var row = dataGridView.Rows[index];

            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string streetName = row.Cells["StreetName"].Value.ToString()!;
            int streetNumber = Convert.ToInt32(row.Cells["StreetNumber"].Value);
            int zipCode = Convert.ToInt32(row.Cells["ZipCode"].Value);
            int buildYear = Convert.ToInt32(row.Cells["BuildYear"].Value);
            int squareMeters = Convert.ToInt32(row.Cells["SquareMeters"].Value);
            int sellerId = Convert.ToInt32(row.Cells["SellerID"].Value);
            int price = Convert.ToInt32(row.Cells["Price"].Value);
            int realtorID = Convert.ToInt32(row.Cells["RealtorID"].Value);
            DateTime dateListed = Convert.ToDateTime(row.Cells["DateListed"].Value);
            DateTime? dateSold = row.Cells["DateSold"].Value == DBNull.Value ? null : Convert.ToDateTime(row.Cells["DateListed"].Value);
            bool sold = Convert.ToInt32(row.Cells["Sold"].Value) == 1;
            int squareMeterPrice = Convert.ToInt32(row.Cells["SqmPrice"].Value);

            var property = new Property(id, streetName, streetNumber, zipCode, buildYear, squareMeters, sellerId, price, realtorID, dateListed, dateSold, sold, squareMeterPrice);

            if (_navigation?.Pages[Pages.UpdateProperty] is UpdatePropertyPage page)
            {
                page.SetupPageDetails(property);
                _navigation.NavigateTo(Pages.UpdateProperty);
            }
        }

        private void bekræftButton_Click(object sender, EventArgs e)
        {
            var updatedSeller = new Seller(
                SellerToUpdate.Id,
                fornavnTextBox.Text,
                efternavnTextBox.Text,
                (cprNrTextBox.Text + cpr2NrTextBox.Text),
                vejnavnTextBox.Text,
                Convert.ToInt32(vejNrTextBox.Text),
                Convert.ToInt32(postNrTextBox.Text),
                telefonTextBox.Text);

            bool rowUpdated = sellerService.UpdateSeller(updatedSeller);

            if (rowUpdated == true)
            {
                MessageBox.Show("Sælgerdata opdateret.", "Data opdateret");
                if (_navigation?.Pages[Pages.ViewSellers] is ViewSellersPage viewSellersPage) viewSellersPage.RefreshFromDb();
                if (_navigation?.Pages[Pages.ViewProperties] is ViewPropertiesPage viewPropertiesPage) viewPropertiesPage.RefreshFromDb();
                SellerToUpdate = updatedSeller;
                SetupPage();
            }
            else
            {
                MessageBox.Show("Ændring af data fejlet.", "Fejl under opdatering");
            }
        }

        private void tilbage_button_Click(object sender, EventArgs e)
        {
            if (SellerDataChanged())
            {
                DialogResult confirm =
                    MessageBox.Show(
                        "Ændringer er ikke gemt. Hvis du fortsætter, vil ændringer blive slettet. Ønsker du at fortsætte?",
                        "Ændringer ej gemt", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _navigation?.NavigateTo(Pages.ViewSellers, false);
                }
            }
            else
            {
                _navigation?.NavigateTo(Pages.ViewSellers, false);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            fornavnTextBox.Text = SellerToUpdate.FirstName;
            efternavnTextBox.Text = SellerToUpdate.LastName;
            cprNrTextBox.Text = SellerToUpdate.CprNumber.Substring(0, 6);
            cpr2NrTextBox.Text = SellerToUpdate.CprNumber.Substring(6, 4);
            vejnavnTextBox.Text = SellerToUpdate.StreetName;
            vejNrTextBox.Text = SellerToUpdate.StreetNumber.ToString();
            postNrTextBox.Text = SellerToUpdate.ZipCode.ToString();
            telefonTextBox.Text = SellerToUpdate.PhoneNumber;
            CheckLabelsText("");

            DialogResult answer = MessageBox.Show("Dette vil slette SÆLGER-profilen samt alle tilknyttede ejendomme. " +
                                                  "Denne handling kan ikke fortrydes. Ønsker du at fortsætte?",
                "Sletning af SÆLGER", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (answer == DialogResult.Yes)
            {
                var sellerDeleted = sellerService.DeleteSeller(SellerToUpdate);

                if (sellerDeleted == true)
                {
                    MessageBox.Show("SÆLGER-profil og tilknyttede ejendomme slettet.",
                        "Slettelse af SÆLGER samt ejendomme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_navigation?.Pages[Pages.ViewSellers] is ViewSellersPage viewSellersPage) viewSellersPage.RefreshFromDb();
                    if (_navigation?.Pages[Pages.ViewProperties] is ViewPropertiesPage viewPropertiesPage) viewPropertiesPage.RefreshFromDb();
                    _navigation?.NavigateTo(Pages.ViewSellers);
                }
                else
                {
                    MessageBox.Show("Noget gik galt under sletning af sælger. Prøv igen senere.",
                        "Fejl under slettelse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateSellerPage_Click(object sender, EventArgs e)
        {
            if (ContainsFocus) ParentForm!.ActiveControl = null;
        }
    }
}

