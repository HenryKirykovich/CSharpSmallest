using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Basic_Concept
{
    internal class Program  // repetition of notions such as delegate and lambda / combination of delegate
    {
        public delegate int MyCourier(int x, int y);   // #1
        public delegate void MyAnonymousDelegate(); // #2
        public delegate object MyAnonymousDelegate2(int num1, int num2); // #3 
        public delegate object MyAnonymousDelegate3(string your_name); // #4 
        public delegate int MyAnonymousDelegate4(int a, int b); // #5


        static void Main(string[] args)
        {
            Console.WriteLine("Put your number:");  // input dates
            int x, y;
            
                Console.WriteLine("First number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Next number:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            
            // +++++++++++++++++++++++++++++++++++++++++++++++++++
            
            
            Console.WriteLine("Path #1");   //  combination delegate and onvoke both via foreach // USEFUl featers

            int Calculation1(int a, int b)
            {
                return a + b;
            }

            int Calculation2(int int1, int int2)
            {
                return int1 * int2 + 10;
            }

            MyCourier myCourier = null;
            MyCourier myCourier1 = Calculation1;
            MyCourier myCourier2 = Calculation2;
            myCourier = myCourier1+myCourier2;
           

            Console.WriteLine($"Hello from standart Delegate: { myCourier(x, y)}");

            Console.WriteLine();

            // +++++++++++++++++++++++++++++++++++++++++++++++++++


            Console.WriteLine();

            Console.WriteLine("Path #1.2 using foreach for iteration all method via delegate object");
            
            foreach (MyCourier method in myCourier.GetInvocationList())
            {
                   
                Console.WriteLine($"Result from {method.Method.Name}: {method(x,y)}");
                Console.WriteLine();
            }

            // +++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine("Path #2  using lambda");
            MyCourier mult = (z, c) => z * c - 1;
            Console.WriteLine($"Hello from Lambda => Delegate {mult(x,y)}");


            // +++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine();
            Console.WriteLine("Path #3  anonymous method without any parameters");

            MyAnonymousDelegate anonymous = new MyAnonymousDelegate(delegate { Console.WriteLine("Hello I am anonymous delegate"); });
            anonymous.Invoke();

            // +++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine();
            Console.WriteLine("Path #3  anonymous method with parameters");

            MyAnonymousDelegate2 anonymous2 = delegate (int num3, int num4) {return Math.Max(num3,num4);};
            Console.WriteLine($"I bring back you Math.Max  {anonymous2(x,y)}");



            // +++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine();
            Console.WriteLine("Path #4  anonymous method with parameters");

            MyAnonymousDelegate3 anonymous3 = delegate (string my_name) 
            {

                if (string.IsNullOrEmpty(my_name))
                    throw new Exception("Hey! Alarm! Incorrect input");
                    
                else
                    return $"your Name was correctly set {my_name}";        
            };
            Console.WriteLine(anonymous3("Henry"));

            // +++++++++++++++++++++++++++++++++++++++++++++++++++

            Console.WriteLine();
            Console.WriteLine("Path #5  anonymous method with parameters");

            // MyAnonymousDelegate4 anonymous4 = (a, b) => { return a + b; };  // OR
            Console.WriteLine(new MyAnonymousDelegate4((c, d) =>
            {
                return c * d;
               


            }).Invoke(x, y));


            //Console.WriteLine(anonymous4(x, y));
            
            
        }
    }
}
