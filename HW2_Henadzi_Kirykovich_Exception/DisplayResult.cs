using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Henadzi_Kirykovich
{
    public class DisplayResult
    {
        public static void Display(Student[] student)
        {
            
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"My name is {student[i].FirstName} {student[i].LastName} and my average is {student[i].GradeAverage()}");
                Console.WriteLine();
            }
            
        }
    }
}
