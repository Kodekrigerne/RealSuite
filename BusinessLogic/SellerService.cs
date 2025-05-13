using DataAccess;
using Models.DTOModels;

namespace BusinessLogic
{
    public class SellerService()
    {
        SellerDBSerivce sellerDBService = new SellerDBSerivce();
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
    }
}
