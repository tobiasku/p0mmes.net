using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("OrderPosition")]
    public class OrderPosition : ParseObject
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        [ParseFieldName("Article")]
        public Article Article
        {
            set { SetProperty<Article>(value); }
            get { return GetProperty<Article>(); }
        }

        [ParseFieldName("ExtraInformation")]
        public string ExtraInformation
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("Quantity")]
        public int Quantity
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }

        [ParseFieldName("Order")]
        public Order Order
        {
            set { SetProperty<Order>(value); }
            get { return GetProperty<Order>(); }
        }
    }
}
