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
        public ParseRelation<Article> Article
        {
            set { SetProperty<ParseRelation<Article>>(value); }
            get { return GetRelationProperty<Article>(); }
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
        public ParseRelation<Order> Order
        {
            set { SetProperty<ParseRelation<Order>>(value); }
            get { return GetRelationProperty<Order>(); }
        }
    }
}
