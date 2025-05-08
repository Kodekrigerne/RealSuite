namespace Models
{
    public class Property
    {
        public Guid Guid { get; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string? Apartment { get; set; }
        public string ZipCode { get; set; }
        public int BuildYear { get; set; }
        public int SquareMeters { get; set; }
        public Seller Seller { get; set; }
        public double Price { get; set; }
        public double? PriceAssessment { get; set; } = null;

        public Property(string streetName, int streetNumber, string? apartment, string zipCode, int buildYear,
            int squareMeters, Seller seller, double price)
        {
            Guid = Guid.NewGuid();
            StreetName = streetName;
            StreetNumber = streetNumber;
            Apartment = apartment;
            ZipCode = zipCode;
            BuildYear = buildYear;
            SquareMeters = squareMeters;
            Seller = seller;
            Price = price;
        }
    }
}
