using System;

namespace C_Henadzi_Kirykovich_user_authentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greeting you in autification system");
            string username;
            string password;
            Console.WriteLine("Please enter your Username");
            username = Console.ReadLine().ToLower();
            Console.WriteLine("");
            Console.WriteLine("Please enter your Login");
            password = Console.ReadLine();
            Console.WriteLine("");
            if (username == "admin" && password == "admin@123")
            {
                Console.WriteLine("You have Full Access");
                Console.WriteLine("");
                Console.WriteLine("Do you want to change your password? Y / N");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "Y") 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please put your NEW Password here and push Enter");
                    string newPass = Console.ReadLine();
                    password = newPass;
                    Console.WriteLine("");
                    Console.WriteLine("Your password was succewssfully change. Your NEW password is {0}. Thank you!", password);
                }

            }   
            else if (username == "guest" && password == "pw@123") 
            {
                Console.WriteLine("You have Limited Guest's Access");
                Console.WriteLine("");
                Console.WriteLine("Do you want to change your password? Y / N");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "Y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please put your NEW Password here and push Enter");
                    string newPass = Console.ReadLine();
                    password = newPass;
                    Console.WriteLine("");
                    Console.WriteLine("Your password was succewssfully change. Your NEW password is {0}. Thank you!", password);
                }
            }
            else if (username == "test" && password == "qwert@123")
            {
                Console.WriteLine("You have only Limited Test's Access");
                Console.WriteLine("");
                Console.WriteLine("Do you want to change your password? Y / N");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "Y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please put your NEW Password here and push Enter");
                    string newPass = Console.ReadLine();
                    password = newPass;
                    Console.WriteLine("");
                    Console.WriteLine("Your password was succewssfully change. Your NEW password is {0}. Thank you!", password);
                }
            }
            else
            {
                Console.WriteLine("Unfotenatly, your Access will be DENIED");
            }




        }
    }
}
