using System.Data;
using System.Diagnostics;
using BusinessLogic;
using Models;
using RealSuite.Enums;
using RealSuite.Events;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class ViewSellersPage : UserControl, IClearable, INavigatable
    {
        private NavigationService? _navigation;
        private readonly SellerService _sellerService = new();
        private EnumerableRowCollection<DataRow>? _table;
        public event EventHandler<UpdateSellerEventArgs>? RowDoubleClick;
        private bool _suspendFiltering = false;
        private int rowIndex;

        public ViewSellersPage()
        {
            _suspendFiltering = true;
            InitializeComponent();
            sellersDataGridView.DataSource = _sellerService.SellersSource;
            _table = ((DataTable)_sellerService.SellersSource.DataSource).AsEnumerable();
            InitializeControls();
            _suspendFiltering = false;
        }

        public void SetNavigation(NavigationService navigation)
        {
            _navigation = navigation;
        }

        private void InitializeControls()
        {
            _suspendFiltering = true;
            zipCodeComboBox.SelectedItem = "Alle";
            phoneNumberComboBox.SelectedItem = "Alle";
            SetZipCodeComboBox();
            SetPhoneNumberComboBox();
            ReFormatCPRNumber();
            RenameColumns();
            _suspendFiltering = false;
        }

        private void ApplyFilters()
        {
            if (!_suspendFiltering)
            {
                zipCodeComboBox.SelectedItem ??= "Alle";
                var zipCodeFilter = zipCodeComboBox.SelectedItem!.ToString();
                phoneNumberComboBox.SelectedItem ??= "Alle";
                var phoneNumberFilter = phoneNumberComboBox.SelectedItem!.ToString();

                _sellerService.ApplyFilters(zipCodeFilter!, phoneNumberFilter!);
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

        public void ReFormatCPRNumber()
        {
            foreach (DataGridViewRow row in sellersDataGridView.Rows)
            {
                if (row.Cells["CprNumber"] != null && row.Cells["CprNumber"].Value.ToString()[6] != '-')
                {
                    string cpr = row.Cells["CprNumber"].Value.ToString()!;
                    string cprReformatted = $"{cpr[0..6]}-{cpr[6..10]}";
                    row.Cells["CprNumber"].Value = cprReformatted;
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
            ApplyFilters();
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
            _sellerService.RefreshFromDB();
            ReFormatCPRNumber();
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
            Debug.WriteLine(cprNumber);

            var seller = new Seller(id, firstName, lastName, cprNumber, streetName, streetNumber, zipCode, phoneNumber);
            var args = new UpdateSellerEventArgs(seller);
            RowDoubleClick?.Invoke(this, args);
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

                    _navigation.NavigateTo(Pages.ViewSellers);
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
