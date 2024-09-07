namespace GenericClassUsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Class");
            Console.WriteLine();

            // instantiating object with different types of data
            MyGeneric<string, string, long> myList;

            
            //populating the data to the object
            Console.WriteLine("Setting your Last name");
            string last = Console.ReadLine();
            Console.WriteLine("Setting your First name");
            string first = Console.ReadLine();
            Console.WriteLine("Setting your number phone");
            long number = Convert.ToInt64(Console.ReadLine());
            myList = new MyGeneric<string, string, long>(last, first, number);

            Console.WriteLine();
            Console.ReadLine();
            //displaing information from object
            Console.WriteLine($"You list included: \n Last Name: {myList.Property1}   First Name: {myList.Property2}   Phone: {myList.Property3} ");

        }
    }
}
