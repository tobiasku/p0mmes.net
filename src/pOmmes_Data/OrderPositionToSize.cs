using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("OrderPositionToSize")]
    public class OrderPositionToSize : ParseObject
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
