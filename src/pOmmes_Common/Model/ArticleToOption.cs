using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class ArticleToOption : Base
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

        public Option Option
        {
            get;
            set;
        }

        public override string ToString()
        {
            if (Option != null)
            {
                return Option.Name + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
