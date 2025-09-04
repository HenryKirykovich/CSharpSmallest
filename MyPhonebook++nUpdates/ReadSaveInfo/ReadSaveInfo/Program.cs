using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Numerics;

namespace ReadSaveInfo
{
    public class Program
    {

        static string mypath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\simpleCatalog.csv";
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<<<< Welcome to Phonebook >>>>>>>");
            Console.WriteLine();

            List<Phonebook> phonebooks = new List<Phonebook>(); // temporarily storage for datas

            string choice = "y";
            int loop_before = 0;
            int loop_after = 0;
            string choiceInner ="y";
            while (choice == "y")
            {
                Console.WriteLine("What Would you Like: Set New - 1 | Read - 2 | Add - 3 | Exit - 0 ?");
                short numCase = Convert.ToInt16(Console.ReadLine());


                switch (numCase)
                {
                    case 1:
                        StreamWriter fileWrite = new StreamWriter(mypath);
                        while (choiceInner == "y")
                        {
                            loop_after++;
                            Console.WriteLine();
                            Console.WriteLine("Please set First name");
                            string first = Console.ReadLine();
                            Console.WriteLine("Please set Last name");
                            string last = Console.ReadLine();
                            Console.WriteLine("Please set number phone");
                            string number = Console.ReadLine();
                            loop_before++;

                            Phonebook entity = new Phonebook(first, last, number);
                            phonebooks.Add(entity);

                            Console.WriteLine();
                            Console.WriteLine($"you have put {loop_before}th records");
                            Console.WriteLine();

                            Console.WriteLine("Do you want continuee? y or n");
                            choiceInner = Console.ReadLine().ToLower();
                            Console.WriteLine();
                        }
                        
                        foreach (var item in phonebooks)
                        {
                            fileWrite.WriteLine(item.First);
                            fileWrite.WriteLine(item.Last);
                            fileWrite.WriteLine(item.Number);
                           
                        }
                        fileWrite.Close();
                        Console.WriteLine();
                        Console.WriteLine("Saving was done");
                        break;

                    case 2:
                        StreamReader fileRead = new StreamReader(mypath);
                        List<string> lines = new List<string>();
                        Console.WriteLine();
                        Console.WriteLine("<<<<<<<<<<<<<< Your current list <<<<<<<<<<<<<<");

                       
                        string line;
                        while ((line = fileRead.ReadLine()) != null)
                        {
                            lines.Add(line);
                            Console.WriteLine(line);

                        }
                        fileRead.Close();
                      
                        Console.WriteLine("Reading was done");
                        choice = "y";
                        break;

                    case 3:
                        StreamReader fileReadTemp = new StreamReader(mypath);
                        string temp;

                        List<Phonebook> tLines = new List<Phonebook>();
                       


                        while ((temp = fileReadTemp.ReadLine()) != null)
                        {
                            string tFirst = fileReadTemp.ReadLine();
                            string tLast = fileReadTemp.ReadLine();
                            string tnumber = fileReadTemp.ReadLine();
                            tLines.Add(new Phonebook(tFirst, tLast, tnumber));
                     
                        }
                        foreach (var item in tLines)
                        {
                            Console.WriteLine(item.First);
                            Console.WriteLine(item.Last);
                            Console.WriteLine(item.Number);

                        }
                        break;


                    case 0:
                        
                            Environment.Exit(0);
                            break;

                    default:
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine();
                Console.WriteLine("Show Menu again? y/n");
                choice = Console.ReadLine().ToLower();
            }

        }
    }
}
