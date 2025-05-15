using System.Data;
using BusinessLogic;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class ViewSellersPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        private readonly SellerService _sellerService = new();
        private EnumerableRowCollection<DataRow>? _table;

        public ViewSellersPage(NavigationService navigation)
        {
            InitializeComponent();
            _navigation = navigation;
            InitializeControls();
        }
        private void InitializeControls()
        {
            sellersDataGridView.DataSource = _sellerService.SellersSource;
            _table = ((DataTable)_sellerService.SellersSource.DataSource).AsEnumerable();
            zipCodeComboBox.SelectedItem = "Alle";
            phoneNumberComboBox.SelectedItem = "Alle";
            SetZipCodeComboBox();
            SetPhoneNumberComboBox();
            ReFormatCPRNumber();
            RenameColumns();
        }

        private void ApplyFilters()
        {
            if (zipCodeComboBox.SelectedItem == null) zipCodeComboBox.SelectedItem = "Alle";
            var zipCodeFilter = zipCodeComboBox.SelectedItem!.ToString();
            if (phoneNumberComboBox.SelectedItem == null) phoneNumberComboBox.SelectedItem = "Alle";
            var phoneNumberFilter = phoneNumberComboBox.SelectedItem!.ToString();

            _sellerService.ApplyFilters(zipCodeFilter, phoneNumberFilter);
            sellersDataGridView.DataSource = _sellerService.SellersSource;
            resultsLabel.Text = $"Resultater: {sellersDataGridView.Rows.Count}";
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
                if (row.Cells["CprNumber"] != null)
                {
                    string cpr = row.Cells["CprNumber"].Value.ToString();
                    string cprReformatted = $"{cpr[0..5]}-{cpr[5..9]}";
                    row.Cells["CprNumber"].Value = cprReformatted;
                }
            }
        }

        private void SetZipCodeComboBox()
        {
            zipCodeComboBox.Items.Clear();
            zipCodeComboBox.Items.Add("Alle");
            zipCodeComboBox.SelectedItem = "Alle";
            zipCodeComboBox.Items.AddRange(_table.Select(x => x.Field<int>("ZipCode")).Distinct().Cast<object>().ToArray());

        }

        private void SetPhoneNumberComboBox()
        {
            phoneNumberComboBox.Items.Clear();
            phoneNumberComboBox.Items.Add("Alle");
            phoneNumberComboBox.SelectedItem = "Alle";
            phoneNumberComboBox.Items.AddRange(_table.Select(x => x.Field<string>("PhoneNumber")).Distinct().Cast<object>().ToArray());
        }

        public void Clear()
        {
            _sellerService.RefreshFromDB();
            InitializeControls();
            ApplyFilters();
        }

        private void zipCodeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void phoneNumberComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
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
    }
}
