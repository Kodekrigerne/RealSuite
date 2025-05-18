using DataAccess;
using Models;
using Models.DTOModels;
using System.Data;

namespace BusinessLogic
{
    public class SellerService
    {
        SellerDBService sellerDBService = new SellerDBService();
        PersonService personService = new PersonService();
        private DataTable _sellersTable;
        public BindingSource SellersSource { get; private set; } = [];

        public SellerService()
        {
            _sellersTable = GetSellers();
            SellersSource.DataSource = _sellersTable;
        }

        public bool CreateSeller(SellerDTO sellerDTO)
        {
            if (VerifySeller(sellerDTO) == true)
            {
                var rowCreated = sellerDBService.CreateSeller(sellerDTO);
                return rowCreated;
            }
            else return false;
        }

        public bool UpdateSeller(Seller seller)
        {
            if (VerifySeller(seller) == true)
            {
                var rowUpdated = sellerDBService.UpdateSeller(seller);
                return rowUpdated;
            }
            return false;
        }

        public void ApplyFilters(string zipCode, string phoneNumber, string[] search)
        {
            string zipCodeFilter = zipCode == "Alle" ? "ZipCode = ZipCode AND" : $"ZipCode = {zipCode} AND";
            string phoneNumberFilter = phoneNumber == "Alle" ? "PhoneNumber = PhoneNumber" : $"PhoneNumber = {phoneNumber}";
            string searchFilter = string.Empty;
            if (search.Length == 1)
            {
                searchFilter = $"AND (StreetName LIKE '%{search[0]}%' " +
                    $"OR (StreetNumber + '') LIKE '{search[0]}' " +
                    $"OR (ZipCode + '') LIKE '{search[0]}'" +
                    $"OR FirstName LIKE '%{search[0]}%'" +
                    $"OR LastName LIKE '%{search[0]}%'" +
                    $"OR PhoneNumber LIKE '{search[0]}')";
            }
            else if (search.Length == 2)
            {
                searchFilter = $"AND ((StreetName LIKE '%{search[0]}%' AND (StreetNumber + '') LIKE '%{search[1]}%') " +
                    $"OR (FirstName LIKE '%{search[0]}%' AND LastName LIKE '%{search[1]}%'))";
            }

            SellersSource.Filter = string.Empty;
            SellersSource.Filter += $"{zipCodeFilter} {phoneNumberFilter} {searchFilter}";
        }

        public bool VerifySeller(Seller seller)
        {
            return personService.VerifyPerson(seller);
        }

        public bool VerifySeller(SellerDTO sellerDTO)
        {
            return personService.VerifyPerson(sellerDTO);
        }

        public DataTable GetSellers()
        {
            var dataTable = sellerDBService.GetSellers();
            return dataTable;
        }

        public void RefreshFromDB()
        {
            _sellersTable = GetSellers();
            SellersSource.DataSource = _sellersTable;
        }

        public DataTable SellerSoldProperties(Seller seller)
        {
            return sellerDBService.SellerSoldProperties(seller);
        }

        public DataTable SellerListedProperties(Seller seller)
        {
            return sellerDBService.SellerListedProperties(seller);
        }

        public bool DeleteSeller(Seller seller)
        {
            var sellerDeleted = sellerDBService.DeleteSeller(seller);

            return sellerDeleted;
        }
    }
}
