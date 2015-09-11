using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class Vote : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public User User
        {
            set;
            get;
        }

        public Restaurant Restaurant
        {
            set;
            get;
        }
    }
}