using System.Threading.Tasks;

namespace AsyncStrategy.TaxStrategy
{
    public interface ITaxStrategy
    {
        Task<decimal> CalculateTaxFor(Order order);
    }
}
