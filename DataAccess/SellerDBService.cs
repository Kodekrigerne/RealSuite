using System.Data;
using Microsoft.Data.SqlClient;
using Models;
using Models.DTOModels;

namespace DataAccess
{
    public class SellerDBService
    {
        public bool CreateSeller(SellerDTO sellerDTO)
        {
            string query = "INSERT INTO Sellers(FirstName, LastName, CprNumber, StreetName, StreetNumber, ZipCode, PhoneNumber) " +
                           "VALUES(@FirstName, @LastName, @CprNumber, @StreetName, @StreetNumber, @ZipCode, @PhoneNumber)";

            int rowsAffected = 0;

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@FirstName", sellerDTO.FirstName);
                    command.Parameters.AddWithValue("@LastName", sellerDTO.LastName);
                    command.Parameters.AddWithValue("@CprNumber", sellerDTO.CprNumber);
                    command.Parameters.AddWithValue("@StreetName", sellerDTO.StreetName);
                    command.Parameters.AddWithValue("@StreetNumber", sellerDTO.StreetNumber);
                    command.Parameters.AddWithValue("@ZipCode", sellerDTO.ZipCode);
                    command.Parameters.AddWithValue("@PhoneNumber", sellerDTO.PhoneNumber);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Seller information:" + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }

            if (rowsAffected == 0) return false;
            else return true;
        }

        public DataTable GetSellers()
        {
            string query = "SELECT * FROM Sellers";
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
                throw new Exception("Error in GetSellers: " + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }
            return dataTable;
        }

        public DataTable SellerSoldProperties(Seller seller)
        {
            string query = "SELECT * FROM Properties WHERE SellerID = @sellerID AND Sold = 1";
            var dataTable = new DataTable();

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@sellerID", seller.Id);

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DataTable SellerSoldProperties: " + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }
            return dataTable;
        }

        public DataTable SellerListedProperties(Seller seller)
        {
            string query = "SELECT * FROM Properties WHERE SellerID = @sellerID AND Sold = 0";
            var dataTable = new DataTable();

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@sellerID", seller.Id);

                    var adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DataTable SellerListedProperties: " + ex.Message);
            }
            finally
            {
                DbConnect.CloseConnection();
            }
            return dataTable;
        }

    }
}
