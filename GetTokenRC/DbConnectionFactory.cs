namespace GetTokenRC
{
    using Npgsql;
    using System.Configuration;
    using System.Data;

    public class DbConnectionFactory
    {
        public string _connectionString { get; set; }

        public DbConnectionFactory()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ConexionVia"].ConnectionString;
        }

        public IDbConnection Create()
        {
            return new NpgsqlConnection(_connectionString);
        }


    }
}
