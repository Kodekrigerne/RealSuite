using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class StatusDBService
    {
        public bool DbCheck()
        {
            string query = "select name from sys.databases where name = 'kodekrigerne_dk_db_realsuite' and state = 0";
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

            }
            finally
            {
                DbConnect.CloseConnection();
            }

            if (dataTable.Rows.Count > 0) return true;
            else return false;
        }
    }
}
