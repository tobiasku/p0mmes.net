using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class Order : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        User User
        {
            get;
            set;
        }

        double Price
        {
            get;
            set;
        }

        Collection<OrderPosition> OrderPositions
        {
            get;
            set;
        }
    }
}
