using System.ComponentModel;
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
        private List<Property> _propertiesList = [];
        public BindingList<Property> FilteredSortedProperties { get; private set; } = [];

        public PropertyService()
        {
            UpdateFromDatabase();
        }

        public void RefreshFromDb()
        {
            UpdateFromDatabase();
        }

        private void UpdateFromDatabase()
        {
            var propertiesTable = GetPropertiesTable();
            _propertiesList = ConvertToList(propertiesTable);
            FilteredSortedProperties = [.. _propertiesList];
        }


        public void ApplyFilters(string soldFilter, int minPrice, int maxPrice)
        {
            FilteredSortedProperties = [.. _propertiesList];

            if (soldFilter == "Solgt")
            {
                FilteredSortedProperties = [.. FilteredSortedProperties.Where(x => x.Sold == true)];
            }
            else if (soldFilter == "Ikke solgt")
            {
                FilteredSortedProperties = [.. FilteredSortedProperties.Where(x => x.Sold == false)];
            }

            FilteredSortedProperties = [.. FilteredSortedProperties.Where(x => x.Price >= minPrice && x.Price <= maxPrice)];
        }

        private static List<Property> ConvertToList(DataTable table)
        {
            List<Property> propertyList = [];

            foreach (DataRow row in table.Rows)
            {
                int Id = Convert.ToInt32(row["Id"]);
                string streetName = row["StreetName"].ToString()!;
                int streetNumber = Convert.ToInt32(row["StreetNumber"]);
                int zipCode = Convert.ToInt32(row["ZipCode"]);
                int buildYear = Convert.ToInt32(row["BuildYear"]);
                int squareMeters = Convert.ToInt32(row["SquareMeters"]);
                int sellerId = Convert.ToInt32(row["SellerID"]);
                double price = Convert.ToDouble(row["Price"]);
                int realtorId = Convert.ToInt32(row["RealtorID"]);
                DateTime dateListed = Convert.ToDateTime(row["DateListed"]);
                DateTime? dateSold = row["DateSold"] == DBNull.Value ? null : Convert.ToDateTime(row["DateSold"]);
                bool sold = Convert.ToBoolean(row["Sold"]);

                var property = new Property(Id, streetName, streetNumber, zipCode, buildYear, squareMeters, sellerId, price, realtorId, dateListed, dateSold, sold);
                propertyList.Add(property);
            }
            return propertyList;
        }

        private DataTable GetPropertiesTable()
        {
            var dataTable = _propertyDbService.GetProperties();
            return dataTable;
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
