using System.Data;
using BusinessLogic;
using Models;
using RealSuite.Enums;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class ViewSellersPage : UserControl, IClearable, INavigatable
    {
        private NavigationService? _navigation;
        private readonly SellerService _sellerService = new();
        private EnumerableRowCollection<DataRow>? _table;
        private bool _suspendFiltering = false;
        private int rowIndex;

        public ViewSellersPage()
        {
            _suspendFiltering = true;
            InitializeComponent();
            sellersDataGridView.DataSource = _sellerService.SellersSource;
            _table = ((DataTable)_sellerService.SellersSource.DataSource).AsEnumerable();
            InitializeControls();
            RenameColumns();
            FormatColumns();
            SetSearchToolTip();
            _suspendFiltering = false;
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
        }

        private void SetSearchToolTip()
        {
            searchInfoPictureBox.Image = SystemIcons.Information.ToBitmap();
            searchInfoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            var searchtoolTip = new ToolTip();
            searchtoolTip.SetToolTip(searchInfoPictureBox, "Søg efter sælgers navn, adresse, postnummer eller telefonnummer.");
        }

        private void InitializeControls()
        {
            _suspendFiltering = true;
            zipCodeComboBox.SelectedItem = "Alle";
            phoneNumberComboBox.SelectedItem = "Alle";
            SetZipCodeComboBox();
            SetPhoneNumberComboBox();
            searchTextBox.Text = string.Empty;
            _suspendFiltering = false;
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            if (!_suspendFiltering)
            {
                zipCodeComboBox.SelectedItem ??= "Alle";
                var zipCodeFilter = zipCodeComboBox.SelectedItem?.ToString();
                phoneNumberComboBox.SelectedItem ??= "Alle";
                var phoneNumberFilter = phoneNumberComboBox.SelectedItem!.ToString();
                var searchFilter = searchTextBox.Text.Trim().Replace("'", "").Split(' ', StringSplitOptions.RemoveEmptyEntries);

                _sellerService.ApplyFilters(zipCodeFilter!, phoneNumberFilter!, searchFilter);
                resultsLabel.Text = $"Resultater: {sellersDataGridView.Rows.Count}";
            }
        }

        public void RenameColumns()
        {
            sellersDataGridView.Columns["FirstName"].HeaderText = "Fornavn";
            sellersDataGridView.Columns["LastName"].HeaderText = "Efternavn";
            sellersDataGridView.Columns["CprNumber"].HeaderText = "CPR-nummer";
            sellersDataGridView.Columns["StreetName"].HeaderText = "Vejnavn";
            sellersDataGridView.Columns["StreetNumber"].HeaderText = "Vejnummer";
            sellersDataGridView.Columns["ZipCode"].HeaderText = "Postnr";
            sellersDataGridView.Columns["PhoneNumber"].HeaderText = "Telefon-nr.";
        }

        public void FormatColumns()
        {
            foreach (DataGridViewRow row in sellersDataGridView.Rows)
            {
                if (row.Cells["CprNumber"] != null && row.Cells["CprNumber"].Value.ToString()![6] != '-')
                {
                    string cprNumber = row.Cells["CprNumber"].Value.ToString()!;
                    string cprNumberFormatted = $"{cprNumber[0..6]}-{cprNumber[6..10]}";
                    row.Cells["CprNumber"].Value = cprNumberFormatted;
                }

                if (row.Cells["PhoneNumber"] != null && row.Cells["PhoneNumber"].Value.ToString()![4] != ' ')
                {
                    string phoneNumber = row.Cells["PhoneNumber"].Value.ToString()!;
                    string phoneNumberFormatted = $"{phoneNumber[0..4]} {phoneNumber[4..8]}";
                    row.Cells["PhoneNumber"].Value = phoneNumberFormatted;
                }
            }
        }

        private void SetZipCodeComboBox()
        {
            zipCodeComboBox.Items.Clear();
            zipCodeComboBox.Items.Add("Alle");
            zipCodeComboBox.SelectedItem = "Alle";
            zipCodeComboBox.Items.AddRange([.. _table!.Select(x => x.Field<int>("ZipCode")).Distinct().Order().Cast<object>()]);
        }

        private void SetPhoneNumberComboBox()
        {
            phoneNumberComboBox.Items.Clear();
            phoneNumberComboBox.Items.Add("Alle");
            phoneNumberComboBox.SelectedItem = "Alle";
            phoneNumberComboBox.Items.AddRange([.. _table!.Select(x => x.Field<string>("PhoneNumber")).Distinct().Order().Cast<object>()]);
        }

        public void Clear()
        {
            InitializeControls();
        }

        private void ZipCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void PhoneNumberComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshFromDb();
        }

        public void RefreshFromDb()
        {
            _sellerService.RefreshFromDB();
            _table = ((DataTable)_sellerService.SellersSource.DataSource).AsEnumerable();
            FormatColumns();
            ApplyFilters();
        }

        #region color highlighting on refresh button and clear button when clicking and hovering
        private void RefreshButton_MouseEnter(object sender, EventArgs e)
        {
            refreshButton.BackColor = Color.FromArgb(168, 228, 214);
            refreshIconPanel.BackColor = Color.FromArgb(168, 228, 214);
        }

        private void RefreshButton_MouseLeave(object sender, EventArgs e)
        {
            refreshButton.BackColor = Color.FromArgb(148, 216, 200);
            refreshIconPanel.BackColor = Color.FromArgb(148, 216, 200);
        }

        private void RefreshButton_MouseDown(object sender, MouseEventArgs e)
        {
            refreshButton.BackColor = Color.FromArgb(203, 246, 235);
            refreshIconPanel.BackColor = Color.FromArgb(203, 246, 235);
        }

        private void RefreshButton_MouseUp(object sender, MouseEventArgs e)
        {
            refreshButton.BackColor = Color.FromArgb(168, 228, 214);
            refreshIconPanel.BackColor = Color.FromArgb(168, 228, 214);
        }

        private void ClearButton_MouseDown(object sender, MouseEventArgs e)
        {
            clearButton.BackColor = Color.Linen;
            clearButtonIconPanel.BackColor = Color.Linen;
        }

        private void ClearButton_MouseUp(object sender, MouseEventArgs e)
        {
            clearButton.BackColor = Color.Bisque;
            clearButtonIconPanel.BackColor = Color.Bisque;
        }

        private void ClearButton_MouseLeave(object sender, EventArgs e)
        {
            clearButton.BackColor = Color.PeachPuff;
            clearButtonIconPanel.BackColor = Color.PeachPuff;
        }

        private void ClearButton_MouseEnter(object sender, EventArgs e)
        {
            clearButton.BackColor = Color.Bisque;
            clearButtonIconPanel.BackColor = Color.Bisque;
        }
        #endregion

        private void SellersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var row = sellersDataGridView.Rows[index];

            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string firstName = row.Cells["FirstName"].Value.ToString() ?? "";
            string lastName = row.Cells["LastName"].Value.ToString() ?? "";
            var cprNumber = row.Cells["CprNumber"].Value.ToString()!.Replace("-", "");
            string streetName = row.Cells["StreetName"].Value.ToString() ?? "";
            int streetNumber = Convert.ToInt32(row.Cells["StreetNumber"].Value);
            int zipCode = Convert.ToInt32(row.Cells["ZipCode"].Value);
            string phoneNumber = row.Cells["PhoneNumber"].Value.ToString() ?? "";

            var seller = new Seller(id, firstName, lastName, cprNumber, streetName, streetNumber, zipCode, phoneNumber);

            if (_navigation?.Pages[Pages.UpdateSeller] is UpdateSellerPage page)
            {
                page.SellerToUpdate = seller;
                page.SetupPage();
                _navigation.NavigateTo(Pages.UpdateSeller);
            }
        }

        private void TopPanel_Click(object sender, EventArgs e)
        {
            if (ActiveControl == searchTextBox) ApplyFilters();
            if (ContainsFocus) ParentForm!.ActiveControl = null;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplyFilters();
                e.SuppressKeyPress = true;
            }
        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = string.Empty;
            ApplyFilters();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text == string.Empty) clearTextButton.Visible = false;
            else clearTextButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var row = sellersDataGridView.Rows[rowIndex];

            Seller selectedSeller = new Seller(
                Convert.ToInt32(row.Cells["Id"].Value),
                row.Cells["FirstName"].Value.ToString() ?? "",
                row.Cells["LastName"].Value.ToString() ?? "",
                row.Cells["CprNumber"].Value.ToString()!.Replace("-", ""),
                row.Cells["StreetName"].Value.ToString() ?? "",
                Convert.ToInt32(row.Cells["StreetNumber"].Value),
                Convert.ToInt32(row.Cells["ZipCode"].Value),
                row.Cells["PhoneNumber"].Value.ToString() ?? "");

            DialogResult answer = MessageBox.Show(
                $"Dette vil slette SÆLGER-profilen '{selectedSeller.FirstName} {selectedSeller.LastName}' samt alle tilknyttede ejendomme. Denne handling kan ikke fortrydes." +
                $"Ønsker du at fortsætte?",
                "Sletning af SÆLGER", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (answer == DialogResult.Yes)
            {
                var sellerDeleted = _sellerService.DeleteSeller(selectedSeller);

                if (sellerDeleted == true)
                {
                    MessageBox.Show("SÆLGER-profil og tilknyttede ejendomme slettet.",
                        "Slettelse af SÆLGER samt ejendomme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_navigation?.Pages[Pages.ViewSellers] is ViewSellersPage viewSellersPage) viewSellersPage.RefreshFromDb();
                    if (_navigation?.Pages[Pages.ViewProperties] is ViewPropertiesPage viewPropertiesPage) viewPropertiesPage.RefreshFromDb();
                }
                else
                {
                    MessageBox.Show("Noget gik galt under sletning af sælger. Prøv igen senere.",
                        "Fejl under slettelse", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sellersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }
    }
}
