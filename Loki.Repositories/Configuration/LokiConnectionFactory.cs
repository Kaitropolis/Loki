using Loki.Repositories.Core;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Loki.Repositories.Configuration
{
    public sealed class LokiConnectionFactory: ILokiConnectionFactory
    {
        private readonly string _connectionString;

        public LokiConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection StartConnection()
        {
            var connection = new SqlConnection(_connectionString);

            connection.Open();

            return connection;
        }
    }
}
