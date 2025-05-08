namespace Models
{
    public class Realtor : Person
    {
        public int Id { get; set; }

        public Realtor(int id, string firstName, string lastName, string cprNumber, string streetName, int streetNumber, string zipCode, string phoneNumber)
            : base(firstName, lastName, cprNumber, streetName, streetNumber, zipCode, phoneNumber)
        {
            Id = id;
        }

        public Realtor(int id, string firstName, string lastName, string cprNumber, string streetName, int streetNumber, string? apartment, string zipCode, string phoneNumber)
            : base(firstName, lastName, cprNumber, streetName, streetNumber, apartment, zipCode, phoneNumber)
        {
            Id = id;
        }
    }
}
