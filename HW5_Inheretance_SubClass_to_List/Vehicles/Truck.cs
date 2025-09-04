using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {

		private int gwv;

		public int GWV
		{
			get { return gwv; }
			set { gwv = value; }
		}


		public Truck()
		{
			gwv = 0;
		}


		public Truck(string pColor, int pWeight, int pGWM) : base(pColor,pWeight)
		{
			gwv = pGWM;
		}

		public override void Print()
		{
			Console.WriteLine($"The color of this truck is {Color}, it weighs {Weight}, and it can carry {GWV} pounds  ");
		}


	}
}
