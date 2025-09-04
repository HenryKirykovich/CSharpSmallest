using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMethodNoDelegate
{

    public delegate void DirectionsDelagate(int count, string xxx);  // this defines a contract, and Directions is a new data type

    class Program
    {

        // run the program, see that it works.
        // uncomment the two lines below amd then write a MyMethod2
        // that does something interesting
        static void Main(string[] args)
        {
            BigMachine myBigMachine = new BigMachine();

            int input1;
            input1 = 4;

            string input2;
            input2= "cat";

            DirectionsDelagate myMethodVariable1 = new DirectionsDelagate(MyMethod1);
            myMethodVariable1(input1, input2);  // delegate variable
          

            Console.WriteLine();
            Console.WriteLine();

           // myMethodVariable12 = MyMethod2;  // delegate variable


            myBigMachine.GiveMeDirections(input1, input2, myMethodVariable1);

            //myBigMachine.GiveMeDirections(input1, input2, myMethodVariable2);



            Console.ReadLine();
        }

        private static void MyMethod1(int val1, string val2)
        {
            string output = "";
            for (int i = 0; i < val1; i++)
            {
                output = output + " " + val2;
            }
            Console.WriteLine(output);
        }

        // write MyMethod2 here.

    }
}
