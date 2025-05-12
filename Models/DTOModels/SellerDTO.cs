namespace Models.DTOModels
{
    public record SellerDTO : PersonDTO
    {

        public SellerDTO(string firstName, string lastName, string cprNumber, string streetName,
            int streetNumber, int zipCode, string phoneNumber)
            : base(firstName, lastName, cprNumber, streetName, streetNumber, zipCode, phoneNumber)
        {
        }
    }
}
