namespace Example_Nested_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Simple Nested Property");


            Coordinate my_coordinate = new Coordinate();
            my_coordinate.point = new Property();
            
            Console.WriteLine("PLease, input first coordinate of point for x axes: ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("PLease, input second coordinate of point for y - axes: ");
            float y = Convert.ToSingle(Console.ReadLine());
            
            my_coordinate.point.height = x;
            my_coordinate.point.width = y;


            // Displaying both coordinate:

            Console.WriteLine();
            Console.WriteLine($"Your point you can find on x (axes) = {my_coordinate.point.height} and y (axes) = {my_coordinate.point.width}");

        }

    }

   
}
