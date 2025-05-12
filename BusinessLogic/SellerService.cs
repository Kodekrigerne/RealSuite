using DataAccess;
using Models.DTOModels;

namespace BusinessLogic
{
    public class SellerService()
    {
        SellerDBSerivce sellerDBService = new SellerDBSerivce();

        public bool CreateSellerDTO(SellerDTO sellerDTO)
        {
            var rowsAffected = sellerDBService.CreateSeller(sellerDTO);

            if (rowsAffected == true) return true;
            else return false;
        }
    }
}
