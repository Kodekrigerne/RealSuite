﻿namespace Models.DTOModels
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
        public int RealtorId { get; set; }
        public DateTime DateListed { get; set; }
        public DateTime? DateSold { get; set; }
        public bool Sold { get; set; }

        public PropertyDTO(string streetName, int streetNumber, int zipCode, int buildYear,
            int squareMeters, int sellerId, double price, int realtorId, DateTime dateListed, DateTime? dateSold, bool sold)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            BuildYear = buildYear;
            SquareMeters = squareMeters;
            SellerId = sellerId;
            Price = price;
            RealtorId = realtorId;
            DateListed = dateListed;
            DateSold = dateSold;
            Sold = sold;
        }
    }
}
