namespace Models
{
    public abstract class Person
    {
        public Guid Guid { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string? Apartment { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string firstName, string lastName, string streetName, int streetNumber, string zipCode, string phoneNumber)
            : this(firstName, lastName, streetName, streetNumber, null, zipCode, phoneNumber) { }

        public Person(string firstName, string lastName, string streetName, int streetNumber, string? apartment, string zipCode, string phoneNumber)
        {
            Guid = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Apartment = apartment;
            ZipCode = zipCode;
            PhoneNumber = phoneNumber;
        }
    }
}
