using System.Data;
using System.Text.RegularExpressions;
using DataAccess;
using Models;
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

        public void ApplyFilters(string sold, int minPrice, int maxPrice, DateTime listedFrom, DateTime listedTo, string zipCode, string sellerID, string[] search)
        {
            string soldFilter = sold == "Alle" ? "" : sold == "Solgt" ? "Sold = 1 AND" : "Sold = 0 AND";
            string priceFilter = $"Price >= {minPrice} AND Price <= {maxPrice} AND";
            string listedFilter = $"DateListed >= #{listedFrom:yyyy-MM-dd}# AND DateListed <= #{listedTo:yyyy-MM-dd}# AND";
            string zipCodeFilter = zipCode == "Alle" ? "ZipCode = ZipCode" : $"ZipCode = {zipCode}";
            string sellerFilter = sellerID == "Alle" ? "SellerID = SellerID" : $"SellerID = {sellerID}";
            string searchFilter = search.Length == 2
                ? $"AND (StreetName LIKE '%{search[0]}%' AND (StreetNumber + '') LIKE '%{search[1]}%')" +
                $"OR (Sælger LIKE '%{search[0]}%' AND Sælger LIKE '%{search[1]}%')"
                : $"AND StreetName LIKE '%{search[0]}%' " +
                $"OR (StreetNumber + '') LIKE '{search[0]}' " +
                $"OR (ZipCode + '') LIKE '{search[0]}'" +
                $"OR (BuildYear + '') LIKE '{search[0]}'" +
                $"OR (DateListed + '') LIKE '{search[0]}%'" +
                $"OR (DateSold + '') LIKE '{search[0]}%'" +
                $"OR Sælger LIKE '%{search[0]}%'";

            PropertiesSource.Filter = string.Empty;
            PropertiesSource.Filter += $"{soldFilter} {priceFilter} {listedFilter} {zipCodeFilter} AND {sellerFilter} {searchFilter}";
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

        public bool UpdateProperty(Property property)
        {
            if (VerifyProperty(property) == true)
            {
                var rowUpdated = _propertyDbService.UpdateProperty(property);
                return rowUpdated;
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

        public bool VerifyProperty(Property property)
        {
            if (!property.StreetName.All(char.IsLetter)) return false;
            if (!property.StreetNumber.ToString().All(char.IsDigit)) return false;
            if (!property.ZipCode.ToString().All(char.IsDigit) || (property.ZipCode < 1000 || property.ZipCode > 9999)) return false;
            if (!property.BuildYear.ToString().All(char.IsDigit)) return false;
            if (!property.SquareMeters.ToString().All(char.IsDigit)) return false;
            if (property.Price < 0) return false;
            if (!Regex.IsMatch(property.DateListed.ToString("yyyy-MM-dd"), @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$"))
                return false;

            return true;
        }
    }
}
