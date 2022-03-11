namespace AsyncStrategy
{
    public class Product
    {


        public Name Name { get; set; }
        public decimal Price { get; set; }
    }

    public enum Name
    {
        TShirtWithInitials,
        TShirtWithNumber,
        TShirtBlank,
    }




}
