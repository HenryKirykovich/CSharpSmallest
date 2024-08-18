using System.Threading.Channels;

namespace List_Interface
{

    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Program
    {
       
        static void Main(string[] args)
        {
            Week newWeek = Week.Friday;
                   
            Console.WriteLine($"Hello, new {newWeek}");

            Console.WriteLine();
            int dayOfWeek = (int)Week.Friday;

            Console.WriteLine($"Hello, new day number is {dayOfWeek}");
            Console.WriteLine( );
            int day = Convert.ToInt32(Week.Saturday);
            Console.WriteLine();
            Console.WriteLine($"your day is {day}");


            Console.WriteLine("Push Enter for launche Print Class");
            Console.Read();
            Print print = new Print();
            print.PrintMethod();
        }
        
    }

    

    class Print
    {
        Week numberDay = Week.Saturday;
        
        public void PrintMethod()
        {
            Console.WriteLine();
            Console.WriteLine($"your choice was {numberDay}");
        }
    }

}
