using System.Data;
using DataAccess;
using Models;
using Models.DTOModels;

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

        public void ApplyFilters(string zipCode, string phoneNumber)
        {
            string zipCodeFilter = zipCode == "Alle" ? "ZipCode = ZipCode AND" : $"ZipCode = {zipCode} AND";
            string phoneNumberFilter = phoneNumber == "Alle" ? "PhoneNumber = PhoneNumber" : $"PhoneNumber = {phoneNumber}";

            SellersSource.Filter = string.Empty;
            SellersSource.Filter += $"{zipCodeFilter} {phoneNumberFilter}";
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
    }
}
