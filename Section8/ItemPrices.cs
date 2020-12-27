using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Section8
{
    public class ItemPrices
    {
        private decimal _wholesale;

        public ItemPrices(decimal wholesale)
        {
            Wholesale = wholesale;
        }

        public decimal Wholesale { get; set; }

    }
}
