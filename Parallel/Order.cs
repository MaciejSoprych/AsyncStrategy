using AsyncStrategy.TaxStrategy;
using System.Threading.Tasks;

namespace AsyncStrategy
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Tax Tax { get; set; }

        public ITaxStrategy TaxStrategy { get; set; }

        public async Task<decimal> CalculatTax()
        {
            var result = await TaxStrategy.CalculateTaxFor(this);
            return result;
        }

    }
}
