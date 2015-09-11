using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class ArticleToSize : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public double Price
        {
            get;
            set;
        }

        public Size Size
        {
            get;
            set;
        }

        public override string ToString()
        {
            if (Size != null)
            {
                return Size.Name + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
