namespace Models
{
    public abstract class Person
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CprNumber { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int id, string firstName, string lastName, string cprNumber, string streetName, int streetNumber, int zipCode, string phoneNumber)
        {
            if (zipCode < 1000 || zipCode > 9999) throw new ArgumentOutOfRangeException(nameof(zipCode));
            if (!cprNumber.All(char.IsDigit) || cprNumber.Length != 10) throw new ArgumentException(nameof(cprNumber));

            Id = id;
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
