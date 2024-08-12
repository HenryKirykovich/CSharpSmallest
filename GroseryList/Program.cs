using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace GroseryList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRandom = new Random();

            FoodItem[] myFood = new FoodItem[5];

            AddFood(myFood);

            Console.WriteLine("Here is your inventory");
            DisplayFood(myFood);

            EatOne(myFood);
            Console.WriteLine();
            Console.WriteLine("Here is your inventory");

            DisplayFood(myFood);

            void AddFood(FoodItem[] _myFood)
            {
                string food;
                decimal cost;
                int life;

                for (int i = 0; i < _myFood.Length; i++)
                {
                    Console.WriteLine("What kind of food is this?");
                    food = Console.ReadLine();
                    Console.WriteLine("How much did it cost?");
                    cost = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("How many days until it spoils?");
                    life = Convert.ToInt32(Console.ReadLine());
                    myFood[i] = new FoodItem(food, cost, life);
                    Console.WriteLine();
                }
            }

            void DisplayFood(FoodItem[] _myFood)
            {
                foreach (FoodItem item in _myFood)
                {
                    if (item != null)
                    {
                        if (item.Description != null)
                        {
                            Console.WriteLine("{0} which cost {1} and will last {2} days.", item.Description, item.Cost, item.ShelfLife);
                        }
                    }
                }
            }

            void EatOne(FoodItem[] _myFood)
            {
                string food = null;
                decimal cost = 0;
                int life = 0;
                int number = myRandom.Next(0, 6);
                myFood[number] = new FoodItem(food, cost, life);
            }

            Console.WriteLine();
            Console.WriteLine("Have a nice day");
            Console.ReadLine();

        }
    }

    public class FoodItem
    {
        public string Description;
        public decimal Cost;
        public int ShelfLife;

        public FoodItem(string _Description, decimal _Cost, int _ShelfLife)

        {

            Description = _Description;
            Cost = _Cost;
            ShelfLife = _ShelfLife;
        }

    }
}
