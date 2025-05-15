using System.Data;
using DataAccess;
using Models.DTOModels;

namespace BusinessLogic
{
    public class SellerService()
    {
        SellerDBService sellerDBService = new SellerDBService();
        PersonService personService = new PersonService();

        public bool CreateSellerDTO(SellerDTO sellerDTO)
        {
            if (VerifySeller(sellerDTO) == true)
            {
                var rowCreated = sellerDBService.CreateSeller(sellerDTO);
                return rowCreated;
            }
            else return false;
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
    }
}
