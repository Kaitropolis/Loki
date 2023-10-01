using System.Data;

namespace Loki.Repositories.Core
{
    public interface ILokiConnectionFactory
    {
        IDbConnection StartConnection();
    }
}
