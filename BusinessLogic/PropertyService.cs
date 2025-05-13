using System.Data;
using DataAccess;
using Models;

namespace BusinessLogic
{
    public class PropertyService
    {
        private readonly PropertyDbService _propertyDbService = new();
        private List<Property> _propertiesList = [];

        public PropertyService()
        {
            UpdateFromDatabase();
        }

        public void RefreshFromDb()
        {
            UpdateFromDatabase();
        }

        public List<Property> GetProperties() => _propertiesList;

        private void UpdateFromDatabase()
        {
            var propertiesTable = GetPropertiesTable();
            _propertiesList = ConvertToList(propertiesTable);
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
                double? priceAssessment = row["PriceAssessment"] == DBNull.Value ? null : Convert.ToDouble(row["PriceAssessMent"]);
                int realtorId = Convert.ToInt32(row["RealtorID"]);
                DateTime dateListed = Convert.ToDateTime(row["DateListed"]);
                DateTime? dateSold = row["DateSold"] == DBNull.Value ? null : Convert.ToDateTime(row["DateSold"]);
                bool sold = Convert.ToBoolean(row["Sold"]);

                var property = new Property(Id, streetName, streetNumber, zipCode, buildYear, squareMeters, sellerId, price, priceAssessment, realtorId, dateListed, dateSold, sold);
                propertyList.Add(property);
            }
            return propertyList;
        }

        private DataTable GetPropertiesTable()
        {
            var dataTable = _propertyDbService.GetProperties();
            return dataTable;
        }
    }
}
