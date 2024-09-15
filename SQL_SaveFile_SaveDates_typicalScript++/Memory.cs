using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL2
{
    internal class Memory
    {
        
            private int courseID;

            public int CourseID
            {
                get { return courseID; }
                set { courseID = value; }
            }


            private int courseNumber;

            public int CourseNumber
            {
                get { return courseNumber; }
                set { courseNumber = value; }
            }


            private string courseDescription;

            public string CourseDescription
            {
                get { return courseDescription; }
                set { courseDescription = value; }
            }

            public Memory()
            {
                CourseID = 0;
                CourseNumber = 0;
                CourseDescription = "";
            }

            public Memory(int pID, int pnumber, string pDescription)
            {
                CourseID = pID;
                CourseNumber = pnumber;
                CourseDescription = pDescription;
            }
        
    }
}
