using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class Article : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        string Name
        {
            get;
            set;
        }

        int Number
        {
            get;
            set;
        }

        Restaurant Restaurant
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        Category Category
        {
            get;
            set;
        }

        Dictionary<Size, double> Sizes
        {
            get;
            set;
        }

        Dictionary<KeyValuePair<Option, Size>, double> Options
        {
            get;
            set;
        }
    }
}
