namespace ListEnumHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("homeWork 7: enum");
            Console.WriteLine();

            GradeSchool student1 = new GradeSchool(Color.blue, "Smith");
            GradeSchool student2 = new GradeSchool(Color.green, "Jones");
            HighSchool student3 = new HighSchool(Color.red, "Lee");
            HighSchool student4 = new HighSchool(Color.blue, "Yee");
            College student5 = new College(Color.green, "Adelaida");
            College student6 = new College(Color.red, "Rossi");

           
            List<Students> myListStudent = new List<Students> {student1, student2, student3, student4, student5,student6,student6};


            foreach (Students name in myListStudent)
            {
                Console.WriteLine($"Last name is {name.LastName}");
            }

            Console.WriteLine();

            List<College> myListCollege = new List<College> { student5, student6 };

            foreach (College item in myListCollege)
            {
                Console.WriteLine($"Last name is {item.LastName}. Class size is {item.Size}, favorite color is {item.FavoriteColor}");
            }

           



        }
    }
}
