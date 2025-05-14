using System.Data;
using DataAccess;
using Models;

namespace BusinessLogic
{
    public class AssessmentService
    {
        AssessmentDBService _assessmentDbService = new AssessmentDBService();

        public int GetAssessment(PriceAssessment priceAssessment)
        {
            DataTable dataTable = _assessmentDbService.GetAssessmentData(priceAssessment);

            if (dataTable.Rows.Count > 2)
            {
                var enumDataTable = dataTable.AsEnumerable();

                var averageSqmPrice = enumDataTable.Select(row => row.Field<decimal>("SqmPrice")).Average();

                return Convert.ToInt32(averageSqmPrice) * priceAssessment.SquareMeters;
            }
            else return 0;
        }
    }
}
