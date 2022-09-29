using Factory_test.DB_connections;

Console.WriteLine("What type of DB connection do  you need?");
var userInput = Console.ReadLine();



MySQLConnection m1 = new MySQLConnection();

m1.ConnectToDB("Connection esablisdh");