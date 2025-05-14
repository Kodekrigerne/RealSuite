namespace Models
{
    public class PriceAssessment
    {
        public int ZipCode { get; set; }
        public int BuildYear { get; set; }
        public int SquareMeters { get; set; }

        public PriceAssessment(int zipCode, int buildYear, int squareMeters)
        {
            ZipCode = zipCode;
            BuildYear = buildYear;
            SquareMeters = squareMeters;
        }
    }
}
