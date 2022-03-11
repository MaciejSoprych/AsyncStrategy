using AsyncStrategy;
using AsyncStrategy.TaxStrategy;
using System.Threading.Tasks;

namespace Parallel.TaxStrategy
{
    public class EnglandTaxStrategy : ITaxStrategy
    {
        public async Task<decimal> CalculateTaxFor(Order order)
        {
            var task = Task.Run(() => order.Tax.Rate * order.Product.Price * 0.2m);
            await task;
            return task.Result;
        }
    }
}
