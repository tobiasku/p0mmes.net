using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class Vote : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        User User
        {
            set;
            get;
        }

        Restaurant Restaurant
        {
            set;
            get;
        }
    }
}