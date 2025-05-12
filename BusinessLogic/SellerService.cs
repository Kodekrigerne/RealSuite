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
                var rowsAffected = sellerDBService.CreateSeller(sellerDTO);
                if (rowsAffected == true) return true;
                else return false;
            }
            else return false;
        }

        public bool VerifySeller(SellerDTO sellerDTO)
        {
            return personService.VerifyPerson(sellerDTO);
        }
    }
}
