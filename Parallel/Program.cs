using AsyncStrategy;
using AsyncStrategy.TaxStrategy;
using System;
using System.Threading.Tasks;

namespace Parallel
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Order order = new Order
            {
                Product = new Product
                {
                    Name = Name.TShirtBlank,
                    Price = 100.00m,
                },

                Tax = new Tax
                {
                    Country = Country.Germany,
                    Rate = 0.23m,
                },

                TaxStrategy = new GermanyTaxStrategy()
            };
            var tax = await order.CalculatTax();
            Console.WriteLine(tax);

        }


    }
}
