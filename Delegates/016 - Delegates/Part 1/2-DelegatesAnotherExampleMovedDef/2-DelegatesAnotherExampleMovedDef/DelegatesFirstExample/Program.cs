using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesFirstExample
{
    public delegate void ProvideGreetingDelegate(string name);
    class Program
    {

        //here I define a method that matches that delegate signature
        public static void HelloMethod(string name)
        {
            Console.WriteLine(" Hello " + name + "!");
        }

        //and another method that matches the delegate signature
        public static void GoodByeMethod(string name)
        {
            Console.WriteLine(" Goodbye " + name + "!");
        }

        //but this method that does NOT match the delegate signature
        public static void HiThereMethod(int number)
        {
            Console.WriteLine("Hi There, " + number.ToString());
        }


        static void Main(string[] args)  // progam that uses the delgates
        {
            // create variable names for variables of type ProvideGreetingDelegate (our new Delegate type)
            // in this version, since the delegate defintion is now in the Program class, 
            // to reference it, I have to add the name of the class where it is defined in front
            ProvideGreetingDelegate delagateVariableA;
            ProvideGreetingDelegate delagateVariableB;

            BeautifulGreetings myBeautifulGreetings = new BeautifulGreetings();

            //assign a value or meaning (a method) to the delegate variable
            delagateVariableA = HelloMethod;  // the method assinged must match the signature of our defined delegate, ProvideGreetingDelegate
            myBeautifulGreetings.Display("Snoopy", delagateVariableA);

            myBeautifulGreetings.Display("Snoopy", HelloMethod);

            Console.WriteLine();
            delagateVariableA = GoodByeMethod;
            myBeautifulGreetings.Display("Snoopy", delagateVariableA);

            //notice that the following line does not work because the method does not have the signature defined by the delegate type
            //delagateVariableB = HiThereMethod;
            // compiler says: No overload for 'HiThereMethod' matches delegate 'DelegatesFirstExample.Program.ProvideGreeting'

            Console.ReadLine();
        }
    }  // end of program class



    public class BeautifulGreetings
    {

        //public delegate void ProvideGreetingDelegate(string name);
        public void Display(string pName, ProvideGreetingDelegate pMethod)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            pMethod(pName);
        }
    }





}
