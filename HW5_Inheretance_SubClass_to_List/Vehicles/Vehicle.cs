using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		private int weight;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public Vehicle()
		{
			color = "";
			weight = 0;
		}


        public Vehicle(string pColor, int pWeight )
        {
            color = pColor;
            weight = pWeight;
        }

        public virtual void Print()
		{
			Console.WriteLine("Hi from parent print");
		}



	}
}
