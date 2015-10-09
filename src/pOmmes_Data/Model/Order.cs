using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Parse;

namespace pOmmes.Data
{
    public class Order : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public ParseUser User
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
