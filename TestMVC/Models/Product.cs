namespace TestMVC.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "Watersport";
        public Product? Related { get; set; }
        public bool InStock { get; } = true;

        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Price = 275M
            };

            Product lafejacket = new Product
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            kayak.Related = lafejacket;

            return new Product[] { kayak, lafejacket, null};
        }
    }
}
