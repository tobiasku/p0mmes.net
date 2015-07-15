using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class Article : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }

        public Restaurant Restaurant
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public Category Category
        {
            get;
            set;
        }

        public Dictionary<Size, double> Sizes
        {
            get;
            set;
        }

        public Collection<Tuple<Option, Size, double>> Options
        {
            get;
            set;
        }
    }
}
