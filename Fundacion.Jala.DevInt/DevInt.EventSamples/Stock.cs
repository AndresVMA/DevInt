using System;
using System.Collections.Generic;
using System.Text;

namespace DevInt.EventSamples
{
    public class Stock
    {
        public delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);
        public event PriceChangeHandler PriceChanged;
        public event EventHandler<PriceEventArgs> PriceChanged2;
        string symbol;
        decimal price;
        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        protected virtual void OnPriceChanged(PriceEventArgs e)
        {
            PriceChanged2?.Invoke(this, e);
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                var oldValue = price;
                price = value;
                //if (PriceChanged != null)
                //    PriceChanged(oldValue, price);
                PriceChanged?.Invoke(oldValue, price);
                OnPriceChanged(new PriceEventArgs(oldValue, price));
            }
        }

    }
}
