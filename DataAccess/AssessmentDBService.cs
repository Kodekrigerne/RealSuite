using System.Data;
using Microsoft.Data.SqlClient;
using Models;

namespace DataAccess
{
    public class AssessmentDBService
    {
        public DataTable GetAssessmentData(PriceAssessment priceAssessment)
        {
            string query = "SELECT SqmPrice FROM Properties WHERE (ZipCode = @zipCode AND BuildYear BETWEEN @lowerYear AND @upperYear AND SquareMeters BETWEEN @lowerSqm AND @upperSqm AND Sold = 1)";
            var dataTable = new DataTable();

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@zipCode", priceAssessment.ZipCode);
                    command.Parameters.AddWithValue("@lowerYear", (priceAssessment.BuildYear - 10));
                    command.Parameters.AddWithValue("@upperYear", (priceAssessment.BuildYear + 10));
                    command.Parameters.AddWithValue("@lowerSqm", (priceAssessment.SquareMeters - 20));
                    command.Parameters.AddWithValue("@upperSqm", (priceAssessment.SquareMeters + 20));

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAssessmentData: " + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }
            return dataTable;
        }
    }
}
