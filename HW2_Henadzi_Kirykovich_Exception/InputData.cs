using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Henadzi_Kirykovich
{
    public class InputData
    {
        public static Student[] Input()
        {
            Student[] student = new Student[3];  // creating new object (array) from class Student and start gathering the information about two student  

            for (int i = 0; i < student.Length; i++)
            {
                try
                {
                    Console.WriteLine("Please input you first name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please input you last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine();
                    

                    student[i] = new Student(firstName, lastName);   //  passed value from new string to my two-parametric constructor
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(ex.ToString());
                                  
                }
                                
            }
            return student;  // return my array to Display class !

        }

    }
}
