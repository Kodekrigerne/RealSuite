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

        public bool UpdateSeller(Seller seller)
        {
            string query =
                "UPDATE Sellers " +
                "SET FirstName = @FirstName, LastName = @LastName, CprNumber = @CprNumber, StreetName = @StreetName, StreetNumber = @StreetNumber, ZipCode = @ZipCode, PhoneNumber = @PhoneNumber " +
                "WHERE Id = @Id";

            int rowsAffected = 0;

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@FirstName", seller.FirstName);
                    command.Parameters.AddWithValue("@LastName", seller.LastName);
                    command.Parameters.AddWithValue("@CprNumber", seller.CprNumber);
                    command.Parameters.AddWithValue("@StreetName", seller.StreetName);
                    command.Parameters.AddWithValue("@StreetNumber", seller.StreetNumber);
                    command.Parameters.AddWithValue("@ZipCode", seller.ZipCode);
                    command.Parameters.AddWithValue("@PhoneNumber", seller.PhoneNumber);
                    command.Parameters.AddWithValue("@Id", seller.Id);

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
                DataTable personTable = new DataTable("Person");

                DataColumn idColumn = new DataColumn();
                idColumn.DataType = typeof(int);
                idColumn.ColumnName = "Id";
                personTable.Columns.Add(idColumn);

                DataColumn firstNameColumn = new DataColumn();
                firstNameColumn.DataType = typeof(string);
                firstNameColumn.ColumnName = "FirstName";
                personTable.Columns.Add(firstNameColumn);

                DataColumn lastNameColumn = new DataColumn();
                lastNameColumn.DataType = typeof(string);
                lastNameColumn.ColumnName = "LastName";
                personTable.Columns.Add(lastNameColumn);

                DataColumn cprNumberColumn = new DataColumn();
                cprNumberColumn.DataType = typeof(string);
                cprNumberColumn.ColumnName = "CprNumber";
                personTable.Columns.Add(cprNumberColumn);

                DataColumn streetNameColumn = new DataColumn();
                streetNameColumn.DataType = typeof(string);
                streetNameColumn.ColumnName = "StreetName";
                personTable.Columns.Add(streetNameColumn);

                DataColumn streetNumberColumn = new DataColumn();
                streetNumberColumn.DataType = typeof(int);
                streetNumberColumn.ColumnName = "StreetNumber";
                personTable.Columns.Add(streetNumberColumn);

                DataColumn zipCodeColumn = new DataColumn();
                zipCodeColumn.DataType = typeof(int);
                zipCodeColumn.ColumnName = "ZipCode";
                personTable.Columns.Add(zipCodeColumn);

                DataColumn phoneNumberColumn = new DataColumn();
                phoneNumberColumn.DataType = typeof(string);
                phoneNumberColumn.ColumnName = "PhoneNumber";
                personTable.Columns.Add(phoneNumberColumn);

                return personTable;
            }
            finally
            {
                DbConnect.CloseConnection();
            }
            return dataTable;
        }

        public DataTable GetSeller(int sellerID)
        {
            string query = "SELECT * FROM Sellers WHERE Id = @sellerID";
            var dataTable = new DataTable();

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    var adapter = new SqlDataAdapter(command);
                    command.Parameters.AddWithValue("@sellerID", sellerID);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetSeller: " + ex.Message);
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

        public bool DeleteSeller(Seller seller)
        {
            string query =
                "DELETE FROM Properties WHERE SellerID = @Id " +
                "DELETE FROM Sellers WHERE Id = @Id";

            int rowsAffected = 0;

            try
            {
                DbConnect.OpenConnection();
                using (var command = new SqlCommand(query, DbConnect.GetConnection()))
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@Id", seller.Id);

                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Deletion of seller:" + ex.Message);
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
