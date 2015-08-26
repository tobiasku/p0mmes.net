using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public class FoodDetailUserControlEventArgs
    {
        private OrderPosition orderPosition = null;
        public OrderPosition OrderPosition { get { return orderPosition; } private set { this.orderPosition = value; } }

        public FoodDetailUserControlEventArgs(OrderPosition orderPosition)
        {
            this.orderPosition = orderPosition;
        }
    }
}
