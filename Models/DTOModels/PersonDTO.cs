namespace Models.DTOModels
{
    public abstract record PersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CprNumber { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public PersonDTO(string firstName, string lastName, string cprNumber, string streetName, int streetNumber, int zipCode, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            CprNumber = cprNumber;
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
        }
    }
}
