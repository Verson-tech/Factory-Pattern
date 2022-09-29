using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_test.DB_connections;

namespace Factory_test.Repos
{
    internal class DepartmnetRepo
    {
        private PostGresSQLConnection _connection = new PostGresSQLConnection();

        //CRUD
        public void InsertDepartment(string departmentName)
        {
            _connection.ConnectToDB(" THe connection string");
            //insert into departments (Name) Values departmentName;
        }
    }
}
