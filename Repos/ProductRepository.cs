using Factory_test.DB_connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_test.Repos
{
    internal class ProductRepository
    {
        private PostGresSQLConnection _connection = new PostGresSQLConnection();

        //CRUD
        public void InsertDepartment(string productName)
        {
            _connection.ConnectToDB(" THe connection string");
            //insert into products (Name) Values productName;
        }

    }
}
