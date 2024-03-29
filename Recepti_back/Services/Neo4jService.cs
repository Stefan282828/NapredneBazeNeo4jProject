using Neo4j.Driver;
using FoodExplorer.Controllers;
using Neo4jClient;


public partial class Neo4jService : IDisposable
{
    private readonly IDriver _driver;

    public Neo4jService(string uri, string username, string password)
    {
        _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(username, password));
    }

    public void Dispose()
    {
        _driver?.Dispose();
    }

}

