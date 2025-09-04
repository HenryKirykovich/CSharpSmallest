using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Henadzi_Kirykovich
{
    public class Student
    {
        private string firstName;   // cteating field#1

        public string FirstName     // protecting field by accessor 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName; // cteating field#2

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Student()   // default constructor but not method
        { }

        public Student(string pFirstName, string pLastName)   // two-parametric constructor
        {
            lastName = pFirstName;
            firstName = pLastName;
        }


        private double[] grades = new double[4] { 9, 10, 8, 10 };  // declare my array with input 's dates

        public double GradeAverage()    // Method for making calculation average grade by itteration my array
        {
            double avg = 0;
            foreach (var item in grades)
            {
                avg += item;
            }
            return (avg / grades.Length);
        }
    }
}
