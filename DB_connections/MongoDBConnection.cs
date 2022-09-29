using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_test.DB_connections
{
    internal class MongoDBConnection : IDbConnection
    {
        public void ConnectToDB(string coonectionString)
        {
            //MySQL specific connection steps
            Console.WriteLine($"Connect to DB {coonectionString}");

            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(".");
            }
            Console.WriteLine();
            Console.WriteLine("Connection esteblished!");
        }
    }
}
