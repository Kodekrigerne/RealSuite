namespace Models
{
    public class Realtor : Person
    {
        public Realtor(int id, string firstName, string lastName, string cprNumber, string streetName, int streetNumber, int zipCode, string phoneNumber)
            : base(id, firstName, lastName, cprNumber, streetName, streetNumber, zipCode, phoneNumber)
        {

        }
    }
}
