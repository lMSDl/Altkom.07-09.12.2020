using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseHandler, IHandler
    {
        public float MaxDiscount { get; }

        public float MinPrice { get; }

        public DiscountHandler(float maxDiscount, float minPrice, IHandler handler) : base(handler)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }
        public DiscountHandler(float maxDiscount, float minPrice) : this(maxDiscount, minPrice, null)
        {
        }

            public bool Discount(float value, float price)
        {
            if(MaxDiscount > value && price >= MinPrice)
            {
                Console.WriteLine($"Tabat przyznany przez {Name}");
                return true;
            }
            return NextHander?.Discount(value, price) ?? false;
        }
    }
}
