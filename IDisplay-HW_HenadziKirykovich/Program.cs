namespace IDisplay_HW_HenadziKirykovich
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The IDisplay program");
            Console.WriteLine();

            


            Book book1 = new Book("Moby Dick", "Herman Mervill", 433);
            Book book2 = new Book("Dune", "Frank Herbert", 398);
            ShortStory ss1 = new ShortStory("The Legend of Sleppy Hollow", "Washington Irving", 53);
            ShortStory ss2 = new ShortStory("The Nightingle and Rose", "Oscar Widle", 40);
            YouTubeVid yt1 = new YouTubeVid("Casey Stoner elbow-sliding", "Termignoni", "sport");
            YouTubeVid yt2 =  new YouTubeVid("Light Pollution Filters for Astrophotography", "AstroBackyard", "Astrophotography");

            List<IDisplay> myList = new List<IDisplay>() { book1, book2, ss1, ss2, yt1, yt2 };

            myList.Sort();
            foreach (IDisplay item in myList)
            {
                item.Display();
            }

            Console.WriteLine();

            List<IDisplay> myList2 = new List<IDisplay>() { book1, book2, ss1, ss2, yt1, yt2 };
            myList2.Sort();
            foreach (IDisplay item in myList2)
            {
                item.Display();
            }





        }
    }
}
