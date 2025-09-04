using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathFunction_HW8
{
    internal class MathFunctions
    {
		
	
		private string[] myFunction = new string[3] { "Square", "Cube", "Factorial" }; 

			


		public float this[int myNumber, string pFunction]
		{
			get
			{
				
				float x = 1;
				for (int i = 0; i < 3; i++)
				{
					if (myFunction[i] == pFunction)
					{
						switch (myFunction[i])
						{
							case "Square":

								x = myNumber * myNumber;
								break;

							case "Cube":

								x = myNumber * myNumber * myNumber;
								break;


							case "Factorial":

								if (myNumber != 0)
								{
									while (myNumber != 1)
									{
										x = x * myNumber;
										myNumber = myNumber - 1;
									}
								}
								if (myNumber == 0)
									x = 1;
								break;

						}

					}

				}
				return x;
			}


		}


	}
}
