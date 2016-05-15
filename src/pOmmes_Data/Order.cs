using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Parse;

namespace pOmmes.Data
{
    [ParseClassName("Order")]
    public class Order : ParseObject
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        [ParseFieldName("User")]
        public ParseRelation<ParseUser> User
        {
            set { SetProperty<ParseRelation<ParseUser>>(value); }
            get { return GetRelationProperty<ParseUser>(); }
        }

        [ParseFieldName("Price")]
        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("Event")]
        public ParseRelation<Event> Event
        {
            set { SetProperty<ParseRelation<Event>>(value); }
            get { return GetRelationProperty<Event>(); }
        }

        [ParseFieldName("Restaurant")]
        public ParseRelation<Restaurant> Restaurant
        {
            set { SetProperty<ParseRelation<Restaurant>>(value); }
            get { return GetRelationProperty<Restaurant>(); }
        }
    }
}
