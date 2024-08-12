namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("List #1 ");
            List<Vehicle> transport = new List<Vehicle>(); // create new list for gathering information  about the objects

                        
            transport.Add(new Car("red", 1000, 150));     // there is the more short way populate the list, because one line create new object
            transport.Add(new Car("blue", 666, 50));
            transport.Add(new Truck("red", 333, 456));
            transport.Add(new Truck("purple", 222, 123));
            transport.Add(new Motorcycle("green", 250, 156));
            transport.Add(new Motorcycle("black", 350, 1000));

            Console.WriteLine();
            Console.WriteLine("Displaying how it is working");
            foreach (Vehicle item in transport)   // we could be used for loop however foreach loop  will be more perfectly 
            {
                item.Print();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine();



            Console.WriteLine("List #2");
            // or we could be use long way to create instances and than set all value to property but we are spending mush line for that
            Car car1 = new Car("red", 1000, 150);
            Car car2 = new Car("blue", 666, 50);
            Truck truck1 = new Truck ("red", 333, 456);
            Truck truck2 = new Truck("purple", 222, 123);
            Motorcycle motorcycle1 = new Motorcycle("green", 250, 999);
            Motorcycle motorcycle2 = new Motorcycle("black", 350, 678);

            // add all object to my list 
            List<Vehicle> transportAll = new List<Vehicle>();

            transportAll.Add(car1);
            transportAll.Add(car2);
            transportAll.Add(truck1);
            transportAll.Add(truck2);
            transportAll.Add(motorcycle1);
            transportAll.Add(motorcycle2);

            Console.WriteLine();
            Console.WriteLine("Displaying how it is working");
            foreach (Vehicle item in transportAll)
            {
                item.Print();
            }




            // or we could be displaying only one parameter from list // or color  or weight  or millage and so on 
            Console.WriteLine();
            Console.WriteLine("This is a list of colors from all objects");
            int countObject = 0;
            foreach (Vehicle item in transportAll)
            {
                countObject++;
                Console.WriteLine($"The object #{countObject} has '{item.Color}' color");
            }


            
        }
    }
}
