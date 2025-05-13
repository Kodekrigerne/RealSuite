using System.Data;
using Microsoft.Data.SqlClient;
using Models.DTOModels;

namespace DataAccess
{
    public class PropertyDbService
    {
        public DataTable GetProperties()
        {
            string query = "SELECT * FROM Properties";
            var dataTable = new DataTable();

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetProperties: " + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }
            return dataTable;
        }

        public bool CreateProperty(PropertyDTO propertyDTO)
        {
            string query =
                "INSERT INTO Properties(StreetName, StreetNumber, ZipCode, BuildYear, SquareMeters, SellerID, Price, RealtorID, DateListed, Sold) " +
                "VALUES(@StreetName, @StreetNumber, @ZipCode, @BuildYear, @SquareMeters, @SellerID, @Price, @RealtorID, @DateListed, @Sold)";

            int rowsAffected = 0;

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@StreetName", propertyDTO.StreetName);
                    command.Parameters.AddWithValue("@StreetNumber", propertyDTO.StreetNumber);
                    command.Parameters.AddWithValue("@ZipCode", propertyDTO.ZipCode);
                    command.Parameters.AddWithValue("@BuildYear", propertyDTO.BuildYear);
                    command.Parameters.AddWithValue("@SquareMeters", propertyDTO.SquareMeters);
                    command.Parameters.AddWithValue("@SellerID", propertyDTO.SellerId);
                    command.Parameters.AddWithValue("@Price", propertyDTO.Price);
                    command.Parameters.AddWithValue("@RealtorID", propertyDTO.RealtorId);
                    command.Parameters.AddWithValue("@DateListed", propertyDTO.DateListed);
                    command.Parameters.AddWithValue("@Sold", propertyDTO.Sold);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Property information:" + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }

            if (rowsAffected == 0) return false;
            else return true;

        }


    }
}
