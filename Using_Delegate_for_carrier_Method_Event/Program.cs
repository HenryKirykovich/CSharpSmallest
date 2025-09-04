namespace Using_Delegate_for_carrier_Method_Event
{
    internal class Program
    {
        public delegate string ClientsAccount(string x, string y, int z);   // declaring # 1 delegate with 3 arguments, which appropriate to methods with 3 arguments

        public delegate string AccountShowing(Accounts list);// declaring  #2 delegate with 1 object

        public delegate void ShowingAnyObjectList(List<Accounts> objectList);// declaring #3  delegate with 1 list - object

        static void Main(string[] args)
        {
            Console.WriteLine("How the Delegate Make me help");
            Console.WriteLine();

            // gathering information inside object 
            Accounts data1 = new Accounts("Henry", "Kirykovich", 9999);
            Accounts data2 = new Accounts("Hanna", "Kirykovich", 7777);
            Accounts data3 = new Accounts("Vlad", "Kirykovich", 555);


            // gathering information inside enumeration object (list) 
            List<Accounts> myList = new List<Accounts>();
            myList.Add(data1);
            myList.Add(data2);
            myList.Add(data3);

            // Simple way pass to another Method int, int , int for printing 

            Console.WriteLine("Printing three arguments");
            ClientsAccount myDelegate = PrintManyArguments;  // invoking method that printing dates by using Delegate #1 
            Console.WriteLine(myDelegate("Henry", "Kirykovich", 9999));
            myDelegate += PrintManyArguments2;


            // for Account object 



            Console.WriteLine();
            Console.WriteLine("Printing object");
            AccountShowing myDelegate2 = Accounts.PrintOneObject; // invoking method that printing dates by using Delegate #2 
            Console.WriteLine(myDelegate2(data1));
            Console.WriteLine(myDelegate2(data2));
            Console.WriteLine(myDelegate2(data3));



             // pass List<object> to Print method

            Console.WriteLine();
            Console.WriteLine("Printing list of object");
            ShowingAnyObjectList myDelegate3 = Accounts.PrintList;  // invoking method that printing dates by using Delegate #3 
            myDelegate3(myList);






            static string PrintManyArguments(string FirstName, string LastName, int ValueMoney)   // declare method that we would like to invoke by Delegate
            {
                return $"Dear, {FirstName} {LastName} you have in your account is ${ValueMoney}";
            }


            static string PrintManyArguments2(string FirstName, string LastName, int ValueMoney)   // declare method that we would like to invoke by Delegate
            {
                return $"Dear, {FirstName} {LastName} you have in your account is ${ValueMoney}";
            }


        }
    }
}
