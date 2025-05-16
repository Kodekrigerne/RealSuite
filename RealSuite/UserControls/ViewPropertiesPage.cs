using System.Data;
using BusinessLogic;
using Models;
using RealSuite.Events;
using RealSuite.Interfaces;
using RealSuite.Services;

namespace RealSuite.UserControls
{
    public partial class ViewPropertiesPage : UserControl, IClearable
    {
        private readonly NavigationService _navigation;
        private readonly PropertyService _propertyService = new();
        public event EventHandler<UpdatePropertyEventArgs>? RowDoubleClick;
        private bool _suspendFiltering = false;
        private EnumerableRowCollection<DataRow>? _table;

        public ViewPropertiesPage(NavigationService navigation)
        {
            _suspendFiltering = true;
            InitializeComponent();
            _navigation = navigation;
            propertiesDataGridView.DataSource = _propertyService.PropertiesSource;
            _table = ((DataTable)_propertyService.PropertiesSource.DataSource).AsEnumerable();
            InitializeControls();
            _suspendFiltering = false;
        }

        private void InitializeControls()
        {
            _suspendFiltering = true;
            searchTextBox.Clear();
            soldComboBox.SelectedItem = "Ikke solgt";
            SetZipCodeComboBox();
            SetSellerComboBox();
            RenameColumns();
            SetTrackBarBounds();
            SetTrackBarInitialValues();
            SetListedDatePickersInitialValues();
            _suspendFiltering = false;
            ApplyFilters();
        }

        private void SetZipCodeComboBox()
        {
            zipCodeComboBox.Items.Clear();
            zipCodeComboBox.Items.Add("Alle");
            zipCodeComboBox.SelectedItem = "Alle";
            zipCodeComboBox.Items.AddRange([.. _table!.Select(x => x.Field<int>("ZipCode")).Distinct().Order().Cast<object>()]);
        }

        private void SetSellerComboBox()
        {
            sellerComboBox.Items.Clear();
            sellerComboBox.Items.Add("Alle");
            sellerComboBox.SelectedItem = "Alle";
            sellerComboBox.Items.AddRange([.. _table!.Select(x => x.Field<int>("SellerID")).Distinct().Order().Cast<object>()]);
        }

        private void RenameColumns()
        {
            propertiesDataGridView.Columns["StreetName"].HeaderText = "Vejnavn";
            propertiesDataGridView.Columns["StreetNumber"].HeaderText = "Vejnr";
            propertiesDataGridView.Columns["ZipCode"].HeaderText = "Postnr";
            propertiesDataGridView.Columns["BuildYear"].HeaderText = "Byggeår";
            propertiesDataGridView.Columns["SquareMeters"].HeaderText = "Kvm";
            propertiesDataGridView.Columns["Price"].HeaderText = "Pris";
            propertiesDataGridView.Columns["DateListed"].HeaderText = "Noteringsdato";
            propertiesDataGridView.Columns["DateSold"].HeaderText = "Salgsdato";
            propertiesDataGridView.Columns["Sold"].HeaderText = "Solgt?";
            propertiesDataGridView.Columns["SqmPrice"].HeaderText = "dkk/m2";
        }

        private void SetListedDatePickersInitialValues()
        {
            DateTime minDate;
            DateTime maxDate;
            try
            {
                minDate = _table!.Min(x => x.Field<DateTime>("DateListed"));
                maxDate = _table!.Max(x => x.Field<DateTime>("DateListed"));
            }
            catch
            {
                minDate = DateTime.Now;
                maxDate = DateTime.Now;
            }

            listedFromDatePicker.Value = minDate;
            listedToDatePicker.Value = maxDate;
        }

        private void ApplyFilters(object? sender = null, EventArgs? e = null)
        {
            if (_suspendFiltering == false)
            {
                var minPriceFilter = minPriceTrackBar.Value;
                var maxPriceFilter = maxPriceTrackBar.Value;
                var listedFrom = listedFromDatePicker.Value;
                var listedTo = listedToDatePicker.Value;
                var solgtFilter = soldComboBox.SelectedItem!.ToString()!;
                var zipCodeFilter = zipCodeComboBox.SelectedItem!.ToString()!;
                var sellerFilter = sellerComboBox.SelectedItem!.ToString()!;
                var searchFilter = searchTextBox.Text.Trim().Replace("'", "").Split(' ');

                _propertyService.ApplyFilters(solgtFilter, minPriceFilter, maxPriceFilter, listedFrom, listedTo, zipCodeFilter, sellerFilter, searchFilter);
                resultsLabel.Text = $"Resultater: {propertiesDataGridView.Rows.Count}";
            }
        }

        public void Clear()
        {
            InitializeControls();
            ApplyFilters();
        }

        private void SetTrackBarInitialValues()
        {
            minPriceTrackBar.Value = minPriceTrackBar.Minimum;
            selectedMinPriceLabel.Text = minPriceTrackBar.Value.ToString();
            maxPriceTrackBar.Value = maxPriceTrackBar.Maximum;
            selectedMaxPriceLabel.Text = maxPriceTrackBar.Value.ToString();
        }

        private void SetTrackBarBounds()
        {
            int minPrice;
            int maxPrice;
            try
            {
                minPrice = (int)_table!.Min(x => x.Field<int>("Price"));
                maxPrice = (int)_table!.Max(x => x.Field<int>("Price"));
            }
            catch
            {
                minPrice = 0;
                maxPrice = 1000;
            }

            minPrice = ((minPrice / 10000) * 10000) - 10000;
            maxPrice = ((maxPrice / 10000) * 10000) + 10000;

            minPriceTrackBar.Minimum = minPrice;
            minPriceTrackBar.Maximum = maxPrice;
            maxPriceTrackBar.Minimum = minPrice;
            maxPriceTrackBar.Maximum = maxPrice;
        }

        private void MinPriceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            selectedMinPriceLabel.Text = minPriceTrackBar.Value.ToString();
        }

        private void MaxPriceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            selectedMaxPriceLabel.Text = maxPriceTrackBar.Value.ToString();
        }

        private void MinPriceTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (minPriceTrackBar.Value > maxPriceTrackBar.Value) minPriceTrackBar.Value = maxPriceTrackBar.Value;
            ApplyFilters();
        }

        private void MaxPriceTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (maxPriceTrackBar.Value < minPriceTrackBar.Value) maxPriceTrackBar.Value = minPriceTrackBar.Value;
            ApplyFilters();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _propertyService.RefreshFromDb();
            ApplyFilters();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ListedFromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (listedToDatePicker.Value < listedFromDatePicker.Value)
            {
                listedToDatePicker.Value = listedFromDatePicker.Value;
            }
            ApplyFilters();
        }

        private void ListedToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (listedFromDatePicker.Value > listedToDatePicker.Value)
            {
                listedFromDatePicker.Value = listedToDatePicker.Value;
            }
            ApplyFilters();
        }

        private void PropertiesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var row = propertiesDataGridView.Rows[index];

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
            var args = new UpdatePropertyEventArgs(property);
            RowDoubleClick?.Invoke(this, args);

        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            if (sender is TrackBar trackBar) trackBar.Value = (trackBar.Value / 10000) * 10000;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ApplyFilters();
        }

        private void TopPanel_Click(object sender, EventArgs e)
        {
            if (ActiveControl == searchTextBox)
            {
                ApplyFilters();
            }
            BeginInvoke(() =>
            {
                if (ContainsFocus) ParentForm!.ActiveControl = null;
            });
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text.Length == 0) clearTextButton.Visible = false;
                else clearTextButton.Visible = true;
            }
        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            ApplyFilters();
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            ExportService exportService = new(_propertyService.PropertiesSource);

            exportService.SaveListToFile();
        }
    }
}
