using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV120___HW_1___Dog_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog[] name = new Dog[2];   // creating new object array for gatering date from another new object
            name[0] = new Dog();
            Console.WriteLine("Please set a breed of dog1");
            name[0].Breed = Console.ReadLine();
            Console.WriteLine("Please set a weight of dog1");
            name[0].Weight = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine();

            name[1] = new Dog();
            Console.WriteLine("Please set a breed of dog2");
            name[1].Breed = Console.ReadLine();
            Console.WriteLine("Please set a weight of dog2");
            name[1].Weight = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine();
            for (int i = 0; i < name.Length; i++)
                    
            {
                Console.WriteLine($"Dog{i + 1} is a {name[i].Breed} and weighs {name[i].Breed} pounds");
            }

            

            Console.ReadLine();
        }

                
    }

    public class Dog
    {
        
        private string _Breed;  
        private int _Weight;

        public string Breed
        {
            get { return _Breed; }   // using accessor for changing value
            set { _Breed = value; }
        }
        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

     
    }
}



