namespace Models.DTOModels
{
    public record PropertyDTO
    {
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

        public PropertyDTO(string streetName, int streetNumber, int zipCode, int buildYear,
            int squareMeters, int sellerId, double price, double? priceassesment, int realtorId, DateTime dateListed, bool sold)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            BuildYear = buildYear;
            SquareMeters = squareMeters;
            SellerId = sellerId;
            Price = price;
            PriceAssessment = priceassesment;
            RealtorId = realtorId;
            DateListed = dateListed;
            Sold = sold;
        }
    }
}
