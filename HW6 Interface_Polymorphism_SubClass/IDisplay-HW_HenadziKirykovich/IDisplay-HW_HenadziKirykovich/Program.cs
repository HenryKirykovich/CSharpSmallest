namespace IDisplay_HW_HenadziKirykovich
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The IDisplay program");
            Console.WriteLine();

            List<IDisplay> myList = new List<IDisplay>();


            myList.Add(new Book("Moby Dick", "Herman Mervill", 433));
            myList.Add(new Book("Dune", "Frank Herbert", 398));
            myList.Add(new ShortStory("The Legend of Sleppy Hollow", "Washington Irving", 53));
            myList.Add(new ShortStory("The Nightingle and Rose", "Oscar Widle", 40));
            myList.Add(new YouTubeVid("Casey Stoner elbow-sliding", "Termignoni", "sport"));
            myList.Add(new YouTubeVid("Light Pollution Filters for Astrophotography", "AstroBackyard", "Astrophotography"));


            foreach (IDisplay item in myList)
            {
                item.Display();
            }



        }
    }
}
