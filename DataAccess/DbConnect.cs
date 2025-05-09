using Microsoft.Data.SqlClient;

namespace DataAccess
{
    internal static class DbConnect
    {
        private static readonly string _password = GetPassword();
        private static readonly string _connectionString = $"Server=mssql11.unoeuro.com; Database=kodekrigerne_dk_db_realsuite; User Id=kodekrigerne_dk; Password={_password}; TrustServerCertificate=True;";
        private static readonly SqlConnection _connection = new(_connectionString);

        private static string GetPassword()
        {
            var solutionRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\.."));
            var envPath = Path.Combine(solutionRoot, "password.env");
            var password = File.ReadLines(envPath).First();
            return password;
        }

        public static void OpenConnection()
        {
            _connection.Open();
        }

        public static void CloseConnection()
        {
            _connection.Close();
        }

        public static SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
