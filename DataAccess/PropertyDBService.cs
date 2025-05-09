using System.Data;
using Microsoft.Data.SqlClient;

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
    }
}
