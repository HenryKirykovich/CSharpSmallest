using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObject_do_foreach
{
    internal class Fruit
    {
        private string _FruitName;
        private string _Color;


        public Fruit() { } // default 

        public Fruit(string fruit, string color)
        {
            _FruitName = fruit;
            _Color = color;
        }


       


        public static void Print(Fruit[] fruits)
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{i+1}. {fruits[i]._FruitName} has color {fruits[i]._Color}");
            }
        }

    }
}
