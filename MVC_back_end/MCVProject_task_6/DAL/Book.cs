
using MCVProject.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using System;

namespace MCVProject.DAL
{
    public class Book
    {
        private IConfiguration config;

        public Book()
        {
            
        }

        public Book(IConfiguration config)
        {
            this.config = config;
        }

        internal string InsertDataBook(PhoneBook x)
        {
            // string with path to DB in my case I use local SQL Server
            string? connectionPath = config.GetConnectionString("MyConnString");

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
            if (reader.Read())
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
        
    }
}
