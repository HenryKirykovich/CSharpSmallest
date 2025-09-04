
using MCVProject.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using System;

namespace MCVProject.DAL
{
    public class Book
    {
        private IConfiguration config;   // creating property for connection appsetting. Important: IConfiration is it interface for it

        public Book()  // default constructor
        {
            
        }

        public Book(IConfiguration config)   // constructor
        {
            this.config = config;
        }

       

        internal string InsertDataBook(PhoneBook x)
        {
            // string with path to DB in my case I use local SQL Server
            string? connectionPath = config.GetConnectionString("MyConnString");  // generic call path to appsetting ( included path to DB)    
            
            //string? connectionPath = config["Connection:String"];  this is way connect diff path from appsetting


            // deploying SqlClient library for connection and creating object
            SqlConnection connection = new SqlConnection(connectionPath);
            // starting starting method
            connection.Open();

            //stringing my query and sending to DB
            string myQuery = "INSERT INTO [dbo].[Person]([FName],[LName],[email],[phone],[address],[UserName],[Password])" +
                "VALUES(@FName, @LName, @email, @phone, @address, @UserName, @Password) select SCOPE_IDENTITY() as id";

            SqlCommand sendData = new SqlCommand(myQuery, connection);// parametrized myQuery that was before 
            sendData.Parameters.AddWithValue("FName", x.FirstName); // parametrized myQuery that was before 
            sendData.Parameters.AddWithValue("LName", x.LastName); // parametrized myQuery that was before 
            sendData.Parameters.AddWithValue("email", x.email);
            sendData.Parameters.AddWithValue("phone", x.Phone);
            sendData.Parameters.AddWithValue("address", x.address);
            sendData.Parameters.AddWithValue("UserName", x.UserName);
            sendData.Parameters.AddWithValue("Password", x.Password);

            // standard method for my DB 'insert all the sending Data and nothing to do'
            //sendData.ExecuteNonQuery();

            SqlDataReader reader = sendData.ExecuteReader(); // sending data and retrieve something

            reader.Read(); // read only
            string id_string = reader["ID"].ToString(); // return only ID from DB

            
            // closing connection
            connection.Close();

            return id_string; // return number ID from row's DB
        }

        internal PhoneBook RetrieveDataBook(string id)
        {

            // string with path to DB in my case I use local SQL Server
            string? connectionPath = config.GetConnectionString("MyConnString");

            // deploying SqlClient library for connection and creating object
            SqlConnection connection = new SqlConnection(connectionPath);
            // starting starting method
            connection.Open();

            //stringing my query and sending to DB
            string myQuery2 = "SELECT [FName], [LName], [email], [phone], [address], [UserName], [Password] FROM [dbo].[Person] WHERE [PersonID] = @id";

            SqlCommand getData = new SqlCommand(myQuery2, connection);
            getData.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = getData.ExecuteReader();

            PhoneBook x = new PhoneBook();
            if (reader.Read())  // check row from DB if null return - false ; if  true populate data  
            {

                x.FirstName = reader["FName"].ToString();
                x.LastName = reader["LName"].ToString();
                x.email = reader["email"].ToString();
                x.Phone = reader["phone"].ToString();
                x.address = reader["address"].ToString();
                x.UserName = reader["UserName"].ToString();
                x.Password = reader["Password"].ToString();

            }
            // close my connection
            connection.Close();

            return x;
        }


        internal bool Update(PhoneBook phonebook, int str)
        {
            // string included the DB's path, I use the local SQL Server
            string? connectionPath = config.GetConnectionString("MyConnString");

            // deploying SqlClient library for connection and creating object/initiating instance
            SqlConnection connection = new SqlConnection(connectionPath);

            // run session to DB
            connection.Open();
           

            //stringing my query and sending to DB my UPDATE
            string myQuery3 = "UPDATE [dbo].[Person] SET [FName] = @FName,[LName] = @LName,[email] = @email,[phone] = @phone,[address] = @address,[UserName] = @UserName,[Password] = @Password WHERE [PersonID] = @PersonID";
            
            //encapsulating query and path
            SqlCommand sendData = new SqlCommand(myQuery3, connection);

            sendData.Parameters.AddWithValue("FName", phonebook.FirstName); // parametrized myQuery that was before 
            sendData.Parameters.AddWithValue("LName", phonebook.LastName); // parametrized myQuery that was before 
            sendData.Parameters.AddWithValue("email", phonebook.email);
            sendData.Parameters.AddWithValue("phone", phonebook.Phone);
            sendData.Parameters.AddWithValue("address", phonebook.address);
            sendData.Parameters.AddWithValue("UserName", phonebook.UserName);
            sendData.Parameters.AddWithValue("Password", phonebook.Password);
            sendData.Parameters.AddWithValue("PersonID", str);
            
            // standard method for my DB 'insert all the sending Data and nothing to do EXCEPT count rows from DB   IF count == 1 that is meaning correct working function'
            int number_rows = sendData.ExecuteNonQuery();

            connection.Close(); // closing session 

            if (number_rows == 1) // check data from DB and convert to bool at the same time 
            {
                return true;
            }
            else
            {
                return false;
            }
         


        }


        internal bool Delete(string iD)
        {
            // string included the DB's path, I use the local SQL Server
            string? connectionPath = config.GetConnectionString("MyConnString");

            // deploying SqlClient library for connection and creating object/initiating instance
            SqlConnection connection = new SqlConnection(connectionPath);

            // run session to DB
            connection.Open();


            //stringing my query and sending to DB my UPDATE
            string myQueryDelete = "DELETE FROM [dbo].[Person] WHERE [PersonID] = @PersonID";

            //encapsulating query and path
            SqlCommand sendData = new SqlCommand(myQueryDelete, connection);

           sendData.Parameters.AddWithValue("PersonID", iD);

            // standard method for my DB 'insert all the sending Data and nothing to do EXCEPT count rows from DB   IF count == 1 that is meaning correct working function'
            int number_rows = sendData.ExecuteNonQuery();

            connection.Close(); // closing session 

            if (number_rows == 1) // check data how a lt rows was delete 
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }


    }
}
