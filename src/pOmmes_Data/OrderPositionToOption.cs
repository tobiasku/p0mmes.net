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

        [ParseFieldName("OrderPosition")]
        public OrderPosition OrderPosition
        {
            set { SetProperty<OrderPosition>(value); }
            get { return GetProperty<OrderPosition>(); }
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
