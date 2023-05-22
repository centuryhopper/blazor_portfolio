using System.Data;
using System.Data.SqlClient;

namespace Portfolio.Server.Contexts;

public class DapperContext
{
    private readonly IConfiguration config;
    private readonly string ConnectionString;
    private readonly string UMS;

    public DapperContext(IConfiguration config)
    {
        this.config = config;
    }

    public IDbConnection CreateConnection() => new SqlConnection(ConnectionString);
}

