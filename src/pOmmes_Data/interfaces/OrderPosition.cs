using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class OrderPosition : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        Article Article
        {
            get;
            set;
        }

        Size Size
        {
            get;
            set;
        }

        Collection<Option> Options
        {
            get;
            set;
        }

        string ExtraInformation
        {
            get;
            set;
        }
    }
}
