using System.Data;
using System.Text.RegularExpressions;
using DataAccess;
using Models.DTOModels;

namespace BusinessLogic
{
    public class PropertyService
    {
        private readonly PropertyDbService _propertyDbService = new();
        private DataTable _propertiesTable;
        public BindingSource PropertiesSource { get; private set; } = [];

        public PropertyService()
        {
            _propertiesTable = GetPropertiesFromDb();
            PropertiesSource.DataSource = _propertiesTable;
        }

        public void RefreshFromDb()
        {
            _propertiesTable = GetPropertiesFromDb();
            PropertiesSource.DataSource = _propertiesTable;
        }

        private DataTable GetPropertiesFromDb()
        {
            var dataTable = _propertyDbService.GetProperties();
            return dataTable;
        }


        public void ApplyFilters(string sold, int minPrice, int maxPrice, DateTime listedFrom, DateTime listedTo)
        {
            string soldFilter = sold == "Alle" ? "" : sold == "Solgt" ? "Sold = 1 AND" : "Sold = 0 AND";
            string priceFilter = $"Price >= {minPrice} AND Price <= {maxPrice} AND";
            string listedFilter = $"DateListed >= #{listedFrom:yyyy-MM-dd}# AND DateListed <= #{listedTo:yyyy-MM-dd}#";

            PropertiesSource.Filter = string.Empty;
            PropertiesSource.Filter += $"{soldFilter} {priceFilter} {listedFilter}";
        }

        public bool CreateProperty(PropertyDTO propertyDTO)
        {
            if (VerifyProperty(propertyDTO) == true)
            {
                var rowCreated = _propertyDbService.CreateProperty(propertyDTO);
                return rowCreated;
            }
            else return false;
        }

        public bool VerifyProperty(PropertyDTO propertyDTO)
        {
            if (!propertyDTO.StreetName.All(char.IsLetter)) return false;
            if (!propertyDTO.StreetNumber.ToString().All(char.IsDigit)) return false;
            if (!propertyDTO.ZipCode.ToString().All(char.IsDigit) || (propertyDTO.ZipCode < 1000 || propertyDTO.ZipCode > 9999)) return false;
            if (!propertyDTO.BuildYear.ToString().All(char.IsDigit)) return false;
            if (!propertyDTO.SquareMeters.ToString().All(char.IsDigit)) return false;
            if (propertyDTO.Price < 0) return false;
            if (!Regex.IsMatch(propertyDTO.DateListed.ToString("yyyy-MM-dd"), @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$"))
                return false;

            return true;
        }
    }
}
