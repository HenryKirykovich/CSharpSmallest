using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
		private int mileage;

		public int Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}

		public Car()
		{
			mileage = 0;
		}


		public Car(string pColor, int pWeight, int pMilage) : base(pColor, pWeight)
		{
			mileage = pMilage;
		}

		public override void Print()
		{
			Console.WriteLine($"The color of this car  is {Color}, it is weighs {Weight}, and it gets {Mileage} miles per gallon");
		}



	}
}
