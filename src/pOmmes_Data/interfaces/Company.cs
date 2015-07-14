using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class Company : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        string Name
        {
            get;
            set;
        }

        string PhoneNumber
        {
            get;
            set;
        }
    }
}
