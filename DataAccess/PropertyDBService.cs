using System.Data;
using Microsoft.Data.SqlClient;
using Models;
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


        public bool UpdateProperty(Property property)
        {
            string query =
                "UPDATE Properties " +
                "SET StreetName = @StreetName, " +
                "    StreetNumber = @StreetNumber, " +
                "    ZipCode = @ZipCode, " +
                "    BuildYear = @BuildYear, " +
                "    SquareMeters = @SquareMeters, " +
                "    SellerID = @SellerID, " +
                "    Price = @Price, " +
                "    RealtorID = @RealtorID, " +
                "    DateListed = @DateListed, " +
                "    DateSold = @DateSold, " +
                "    Sold = @Sold " +
                "WHERE Id = @Id";

            int rowsAffected = 0;

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.Parameters.AddWithValue("@Id", property.Id);
                    command.Parameters.AddWithValue("@StreetName", property.StreetName);
                    command.Parameters.AddWithValue("@StreetNumber", property.StreetNumber);
                    command.Parameters.AddWithValue("@ZipCode", property.ZipCode);
                    command.Parameters.AddWithValue("@BuildYear", property.BuildYear);
                    command.Parameters.AddWithValue("@SquareMeters", property.SquareMeters);
                    command.Parameters.AddWithValue("@SellerID", property.SellerId);
                    command.Parameters.AddWithValue("@Price", property.Price);
                    command.Parameters.AddWithValue("@RealtorID", property.RealtorId);
                    command.Parameters.AddWithValue("@DateListed", property.DateListed);
                    if (property.DateSold == null)
                    {
                        command.Parameters.AddWithValue("@DateSold", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DateSold", property.DateSold);
                    }
                    command.Parameters.AddWithValue("@Sold", property.Sold);

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
