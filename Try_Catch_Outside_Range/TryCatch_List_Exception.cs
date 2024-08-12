using System;
using System.ComponentModel.Design;
using System.Data;

namespace Try_Catch_Outside_Range
{
    internal class TryCatch_List_Exception
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Check-in of range of input to 32 entered to list ---");
            List<int> number = new List<int>();
            try
            {
                Console.WriteLine("Please input number from 0 to 32 or input 'exit' to finish:");
                string input;
               
                bool x = true;
                while(x)
                {
                    input = Console.ReadLine();
                   
                    if (input == "exit")
                    {
                        Console.WriteLine("Thank you. Buy!");
                        x = false;
                        break;
                    }
                    else if (Convert.ToInt32(input) < 32 && Convert.ToInt32(input) < 0)
                    {
                        Console.WriteLine("your input was incorrect");
                        break;
                    }
                    else
                    {
                        number.Add(Convert.ToInt32(input));
                    }
                    
                                      


                }

                Console.WriteLine("Would you like display it?");
                Console.ReadLine();
                foreach (var item in number)
                {
                    Console.WriteLine($"Your number is: {item}");
                    Console.WriteLine();
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"Something wrong.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
            }
            
        }
    }
}
