using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
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

        public ArticleToSize Size
        {
            get;
            set;
        }

        public Collection<ArticleToOption> Options
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
