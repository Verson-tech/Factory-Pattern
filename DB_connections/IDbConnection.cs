using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_test.DB_connections
{
    internal interface IDbConnection
    {
        public IDbConnection GetDbConnection(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "mongo":
                    return new MongoDBConnection();
                case "mysql":
                    return new MySQLConnection();
                case "postgres":
                    return new PostGresSQLConnection();
                default:
                    return new MySQLConnection();

            }
        }
    }
}
