namespace Example_Nested_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Simple Nested Property");


                      
            
            Console.WriteLine("PLease, input first coordinate of point for x axes: ");    // input coordinate
            float x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("PLease, input second coordinate of point for y - axes: ");
            float y = Convert.ToSingle(Console.ReadLine());



            Coordinate my_coordinate = new Coordinate(x,y);  // initialiasation new object and passing coordinate
           


            // Displaying both coordinate:

            Console.WriteLine();
            Console.WriteLine($"Your point you can find on x (axes) = {my_coordinate.point.height} and y (axes) = {my_coordinate.point.width}");

        }

    }

   
}
