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
        public ParseUser User
        {
            set { SetProperty<ParseUser>(value); }
            get { return GetProperty<ParseUser>(); }
        }

        [ParseFieldName("Price")]
        public double Price
        {
            get { return GetProperty<double>(); }
            set { SetProperty<double>(value); }
        }

        [ParseFieldName("Event")]
        public Event Event
        {
            set { SetProperty<Event>(value); }
            get { return GetProperty<Event>(); }
        }

        [ParseFieldName("Restaurant")]
        public Restaurant Restaurant
        {
            set { SetProperty<Restaurant>(value); }
            get { return GetProperty<Restaurant>(); }
        }
    }
}
