using System.Text;
using System;

namespace C_Henadzi_Kirykovich_Orange_Juice_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program for counting drunk orange juice");
            Console.WriteLine();
            
            float sizeContainer;
            Console.WriteLine("What is the weight (in oz.) of the original container of OJ did you buy?");
            sizeContainer = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is the cost of the original container of OJ in dollars?");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            decimal cost1OZ = price / (Convert.ToDecimal(sizeContainer));
            Console.WriteLine();
            /*Console.WriteLine("Price 1 oz will be ${0}", cost1oz);
            Console.WriteLine();*/
            
            int time = 1;      // counting time
            int quantity;   // amount of juice drunk
             
            decimal runningTotal=0; // collect total due

           while (true)
            {
                
                Console.WriteLine();
                Console.WriteLine($"How much juice did you take time {time++}");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity ==0) 
                {
                    break; 
                }

                runningTotal += quantity * cost1OZ;
                /*Console.WriteLine("your due Total {0}", runningTotal);*/

                if (runningTotal >= 10)

                {
                    Console.WriteLine("Your roommate owes you $10");
                    runningTotal -= 10;
                   
                }
            } Console.WriteLine($"Your roommate owes you {Math.Round(runningTotal, 2)}" );   // round final due
        }
    }
}
