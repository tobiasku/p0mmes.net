using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class Order : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public User User
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public Collection<OrderPosition> OrderPositions
        {
            get;
            set;
        }
    }
}
