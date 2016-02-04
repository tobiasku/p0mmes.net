using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("OrderPositionToOption")]
    public class OrderPositionToOption : ParseObject
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

        [ParseFieldName("Option")]
        public ParseRelation<Option> Option
        {
            set { SetProperty<ParseRelation<Option>>(value); }
            get { return GetRelationProperty<Option>(); }
        }

        [ParseFieldName("Article")]
        public ParseRelation<Article> Article
        {
            set { SetProperty<ParseRelation<Article>>(value); }
            get { return GetRelationProperty<Article>(); }
        }

        [ParseFieldName("OrderPosition")]
        public ParseRelation<OrderPosition> OrderPosition
        {
            set { SetProperty<ParseRelation<OrderPosition>>(value); }
            get { return GetRelationProperty<OrderPosition>(); }
        }

        public override string ToString()
        {
            if (Option != null)
            {
                return Option.ToString() + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
