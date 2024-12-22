namespace TestShop.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortDesc {  get; set; }
        public string? FullDesc { get; set; }
        public int Price { get; set; }
        public string? Img { get; set; }
        public bool? IsFavourite { get; set; }  // showing main page if true  or no show if false
        public bool? Available { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
       


    }
}
