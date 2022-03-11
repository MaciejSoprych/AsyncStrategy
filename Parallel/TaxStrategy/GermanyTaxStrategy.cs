using System.Threading.Tasks;

namespace AsyncStrategy.TaxStrategy
{
    public class GermanyTaxStrategy : TaxStrategy
    {
        public override async Task<decimal> CalculateTaxFor(Order order)
        {
            var basis = await base.CalculateTaxFor(order);
            var task = Task.Run(() => basis * 2);
            await task;
            return task.Result;
        }
    }
}
