namespace Models
{
    public class Property
    {
        public int Id { get; }
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public int BuildYear { get; set; }
        public int SquareMeters { get; set; }
        public int SellerId { get; set; }
        public double Price { get; set; }
        public double? PriceAssessment { get; set; } = null;
        public int RealtorId { get; set; }
        public DateTime DateListed { get; set; }
        public DateTime? DateSold { get; set; }
        public bool Sold { get; set; }

        public Property(int id, string streetName, int streetNumber, int zipCode, int buildYear,
            int squareMeters, int sellerId, double price, double? priceAssessment, int realtorId, DateTime dateListed, DateTime? dateSold, bool sold)
        {
            Id = id;
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            BuildYear = buildYear;
            SquareMeters = squareMeters;
            SellerId = sellerId;
            Price = price;
            PriceAssessment = priceAssessment;
            RealtorId = realtorId;
            DateListed = dateListed;
            DateSold = dateSold;
            Sold = sold;
        }
    }
}
