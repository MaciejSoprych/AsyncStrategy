using System.Threading.Tasks;

namespace AsyncStrategy.TaxStrategy
{
    public abstract class TaxStrategy : ITaxStrategy
    {

        public virtual async Task<decimal> CalculateTaxFor(Order order)
        {
            var task = Task.FromResult(order.Tax.Rate * order.Product.Price);
            var result = await task;
            return result;
        }
    }
}
