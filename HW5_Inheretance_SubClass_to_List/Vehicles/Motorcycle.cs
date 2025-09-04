using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorcycle : Vehicle
    {
		private decimal displacment;

		public decimal Displacment
        {
			get { return displacment; }
			set { if ((value > 1500) || (value < 100))
				{
					Console.WriteLine("your engine size, should be not less 100 and not more 1500");   // add simple protection for entering incorrect data
				}
				else
				{
                    displacment = value;                 }   // between 100 and 1500 
            }
				
				
				
		}

		public Motorcycle()
		{
			displacment = 0;

		}

		public Motorcycle(string pColor, int pWeight, int pDisplacement) : base(pColor,pWeight)
		{
			Displacment = pDisplacement;
		}

		public override void Print()
		{
			Console.WriteLine($"The color of this {Color}, it weighs  {Weight}, and engine is {Displacment}");
		}

	}
}
