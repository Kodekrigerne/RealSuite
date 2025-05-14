using System.Data;
using BusinessLogic;
using DataAccess;
using RealSuite.Interfaces;

namespace RealSuite.UserControls
{
    public partial class ViewPropertiesPage : UserControl, IClearable
    {
        private readonly PropertyService _propertyService = new();
        public ViewPropertiesPage()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            propertiesDataGridView.DataSource = _propertyService.PropertiesSource;
            soldComboBox.SelectedItem = "Alle";
            zipCodeComboBox.SelectedItem = "Alle";
            sellerComboBox.SelectedItem = "Alle";
            SetZipCodeComboBox();
            SetSellerComboBox();
            RenameColumns();
            SetTrackBarBounds();
            SetTrackBarInitialValues();
            SetListedDatePickersInitialValues();
        }

        private void SetZipCodeComboBox()
        {
            var table = ((DataTable)_propertyService.PropertiesSource.DataSource).AsEnumerable();
            zipCodeComboBox.Items.AddRange(table.Select(x => x.Field<int>("ZipCode")).Distinct().Cast<object>().ToArray());
        }

        private void SetSellerComboBox()
        {
            var table = ((DataTable)_propertyService.PropertiesSource.DataSource).AsEnumerable();
            sellerComboBox.Items.AddRange(table.Select(x => x.Field<int>("SellerID")).Distinct().Cast<object>().ToArray());
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
        }

        private void SetListedDatePickersInitialValues()
        {
            var table = ((DataTable)_propertyService.PropertiesSource.DataSource).AsEnumerable();

            DateTime minDate;
            DateTime maxDate;
            try
            {
                minDate = table.Min(x => x.Field<DateTime>("DateListed"));
                maxDate = table.Max(x => x.Field<DateTime>("DateListed"));
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
            var solgtFilter = soldComboBox.SelectedItem!.ToString()!;
            var minPriceFilter = minPriceTrackBar.Value;
            var maxPriceFilter = maxPriceTrackBar.Value;
            var listedFrom = listedFromDatePicker.Value;
            var listedTo = listedToDatePicker.Value;
            if (zipCodeComboBox.SelectedItem == null) zipCodeComboBox.SelectedItem = "Alle";
            var zipCodeFilter = zipCodeComboBox.SelectedItem!.ToString()!;
            if (sellerComboBox.SelectedItem == null) sellerComboBox.SelectedItem = "Alle";
            var sellerFilter = sellerComboBox.SelectedItem!.ToString()!;

            _propertyService.ApplyFilters(solgtFilter, minPriceFilter, maxPriceFilter, listedFrom, listedTo, zipCodeFilter, sellerFilter);
            propertiesDataGridView.DataSource = _propertyService.PropertiesSource;
            resultsLabel.Text = $"Resultater: {propertiesDataGridView.Rows.Count}";
        }

        public void Clear()
        {
            _propertyService.RefreshFromDb();
            InitializeControls();
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
            var table = ((DataTable)_propertyService.PropertiesSource.DataSource).AsEnumerable();

            int minPrice;
            int maxPrice;
            try
            {
                minPrice = (int)table.Min(x => x.Field<Decimal>("Price"));
                maxPrice = (int)table.Max(x => x.Field<Decimal>("Price"));
            }
            catch
            {
                minPrice = 0;
                maxPrice = 1000;
            }

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
            InitializeControls();
        }

        private void listedFromDatePicker_ValueChanged(object sender, EventArgs e)
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

        private void ZipCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void SellerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
