using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class OrderPosition : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public Article Article
        {
            get;
            set;
        }

        public Size Size
        {
            get;
            set;
        }

        public Collection<Option> Options
        {
            get;
            set;
        }

        public string ExtraInformation
        {
            get;
            set;
        }
    }
}
