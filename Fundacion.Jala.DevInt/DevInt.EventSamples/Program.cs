using System;

namespace DevInt.EventSamples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stock stock = new Stock("$");
            stock.Price = 20m;
            stock.PriceChanged += Stock_PriceChanged;
            stock.PriceChanged2 += Stock_PriceChanged2;
            stock.Price = 21m;
        }

        private static void Stock_PriceChanged2(object sender, PriceEventArgs e)
        {
            if (e.NewPrice > e.OldPrice)
            {
                Console.WriteLine("Price has increased");
            }
        }

        private static int Stock_PriceChanged(decimal oldPrice, decimal newPrice)
        {
            if (newPrice > oldPrice)
            {
                Console.WriteLine("Price has increased");
            }
            return 0;
        }
    }
}
