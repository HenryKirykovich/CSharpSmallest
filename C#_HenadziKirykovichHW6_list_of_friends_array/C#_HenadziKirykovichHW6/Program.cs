using System.Threading.Channels;

namespace C__HenadziKirykovichHW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            string[] show = new string[5];
            string[] pet = new string[5];

            for (int i = 0; i<name.Length ; i++)
            {
                Console.WriteLine($"Please input your {i+1}st friend's name");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine(); 
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"Your {i+1}st friend is {name[i]}");
                Console.WriteLine();
                Console.WriteLine($"{i+1},what is the name of your favorite TV show?");
                show[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"{i+1},what is the name of your favorite pet?");
                pet[i] = Console.ReadLine();
                Console.WriteLine();
            }

            string input_user;
            Console.WriteLine();
            Console.WriteLine("Enter please your friend's name OR enter 'done' for close program");
            input_user = Console.ReadLine();

            while (input_user != "done")
            {
                bool found = false;
    
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == input_user)
                    {
                        Console.WriteLine(name[i]);
                        Console.WriteLine(
                            $"{name[i]}'s favorite TV show is {show[i]} and his pet's name is {pet[i]}");
                        Console.WriteLine();
                        found = true;
                        
                    }
                }
    
                if (!found) 
                {
                    Console.WriteLine("Did not find that person");
                    Console.WriteLine();
                }

                Console.WriteLine("Enter please your friend's name OR enter 'done' for close program");
                input_user = Console.ReadLine();
                Console.WriteLine();
            }
        }   
    }
}
