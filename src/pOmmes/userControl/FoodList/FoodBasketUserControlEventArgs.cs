
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public class FoodBasketUserControlEventArgs
    {
        private Order order = null;
        public Order Order { get { return order; } private set { this.order = value; } }

        public FoodBasketUserControlEventArgs(Order order)
        {
            this.order = order;
        }
    }
}