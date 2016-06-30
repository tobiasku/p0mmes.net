using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("ArticleToOption")]
    public class ArticleToOption : ParseObject
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        [ParseFieldName("Price")]
        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("Size")]
        public Size Size
        {
            set { SetProperty<Size>(value); }
            get { return GetProperty<Size>(); }
        }

        [ParseFieldName("Option")]
        public Option Option
        {
            set { SetProperty<Option>(value); }
            get { return GetProperty<Option>(); }
        }

        [ParseFieldName("Article")]
        public Article Article
        {
            set { SetProperty<Article>(value); }
            get { return GetProperty<Article>(); }
        }

        public override string ToString()
        {
            if (Option != null)
            {
                return Option.Name.ToString() + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
