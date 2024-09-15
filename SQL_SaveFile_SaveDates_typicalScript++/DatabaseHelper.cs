using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL2
{
    public class DatabaseHelper
    {

        private string _connectingString;

        internal DatabaseHelper(string connectionString)
        {
            _connectingString = connectionString;  //  add encapsulation and protection string (OPTIONALY)

        }


        internal List<Memory> GetCourses()
        {
            List<Memory> courses = new List<Memory>();   // COURSES is object 

            using (SqlConnection connection = new SqlConnection(_connectingString))   // create path t SQL
            {
                try
                {
                    connection.Open();                                       // open SQL table
                    Console.WriteLine("Connection was Successful!");
                    Console.WriteLine();
                    Console.WriteLine();

                    string query = "SELECT * FROM Courses;";     // read your request to SQL here 

                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a new Course object and populate its properties
                                Memory course = new Memory(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));     // COURSE is object for save dates from SQL

                                // Add the Course object to the list
                                courses.Add(course);
                            }

                        }
                    }



                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                }

            }
            return courses;
        }
    }
}
