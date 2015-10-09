using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
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

        public Collection<ArticleToSize> Sizes
        {
            get;
            set;
        }

        public Collection<ArticleToOption> Options
        {
            get;
            set;
        }
    }
}
