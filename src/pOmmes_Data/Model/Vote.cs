using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Vote : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public ParseUser User
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