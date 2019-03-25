using System;
using System.Collections.Generic;
using System.Text;

namespace DevInt.EventSamples
{
    public class PriceEventArgs : EventArgs
    {
        public decimal OldPrice { get; private set; }
        public decimal NewPrice { get; private set; }
        public PriceEventArgs()
        {
                
        }
        public PriceEventArgs(decimal oldPrice, decimal newPrice)
        {
            this.OldPrice = oldPrice;
            this.NewPrice = newPrice;
        }
    }
}
