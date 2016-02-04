using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("ArticleToSize")]
    public class ArticleToSize : ParseObject
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
        public ParseRelation<Size> Size
        {
            set { SetProperty<ParseRelation<Size>>(value); }
            get { return GetRelationProperty<Size>(); }
        }

        [ParseFieldName("Article")]
        public ParseRelation<Article> Article
        {
            set { SetProperty<ParseRelation<Article>>(value); }
            get { return GetRelationProperty<Article>(); }
        }

        public override string ToString()
        {
            if (Size != null)
            {
                return Size.ToString() + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
