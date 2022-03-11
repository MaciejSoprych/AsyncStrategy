namespace AsyncStrategy
{
    public class Tax
    {
        public Country Country { get; set; }
        public decimal Rate { get; set; }
    }

    public enum Country
    {
        England,
        Poland,
        Germany,
        Italy
    }
}
