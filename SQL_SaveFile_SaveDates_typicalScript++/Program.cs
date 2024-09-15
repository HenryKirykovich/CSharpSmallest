using System;
using System.Collections.Generic;
using System.IO;

namespace SQL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataBasaReader");


            string connetionString = "Server=GIN\\SQLEXPRESS;Database=MurachCollege;Integrated Security=True";   // line path to MyDataBase

            
            DatabaseHelper dbHelper = new DatabaseHelper(connetionString);   // constructor save and encapsulate a path of SQL's table ( OPTIONALY)

            
            List<Memory> courses = new List<Memory>();    // create object for save list from DatabaseHelper class


            courses = dbHelper.GetCourses(); // called method return dates from database 


            // chunk of code displaing what save into object / itteration 

            int number = 0;

            foreach (var course in courses)    // displaing what save into object / itteration 
            {
                number++;
                Console.WriteLine($"#{number}, ID: {course.CourseID}, Course Number:  {course.CourseNumber}, CourseDescription:  {course.CourseDescription}");

                
            }

            Console.WriteLine();
            Console.WriteLine("Upload was Completed");



            // show my file from local PC

            //1. save path
            string mypath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DataTable.csv";   // add path to creating file 
                      


            Console.WriteLine("Would you like save your result inside file?");
            Console.ReadLine();

            // 2. create instance 
            StreamWriter fileWrite = new StreamWriter(mypath);   // typical command from StreamWriter / Object for create and save dates 

            // 3. saving data
            fileWrite.WriteLine($"#\tID:\tCourse Number:\tCourseDescription:");
            int number2 = 0;
            foreach (var course in courses)
            {
                number2++;
                fileWrite.WriteLine($"{number2}\t{course.CourseID}\t{course.CourseNumber}\t{course.CourseDescription}");

                // file.WriteLine( something )  method for save dates 
            }
            // 4. Important closed file any time after
            fileWrite.Close();   // method closed file ! it is nessecerally! 
                     
            Console.WriteLine("File was Successfully created");


            // chunk of code for reading the saved  file
            Console.WriteLine();
            Console.WriteLine("Would you like Read your result from file?");
            Console.ReadLine();

            StreamReader fileRead = new StreamReader(mypath);  // typical command from StreamReader / Object for Read 

            string line;
            while((line = fileRead.ReadLine()) != null)   //use while for displaying until dates will be off
            {
                Console.WriteLine(line);
            }
            fileRead.Close();   // method closed file ! it is nessecerally! 
           
            Console.WriteLine("File was Successfully read");
            Console.ReadLine();
        }
    }
}
