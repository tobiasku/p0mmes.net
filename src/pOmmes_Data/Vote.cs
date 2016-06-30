using Parse;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("Vote")]
    public class Vote : ParseObject
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

        [ParseFieldName("Restaurant")]
        public Restaurant Restaurant
        {
            set { SetProperty<Restaurant>(value); }
            get { return GetProperty<Restaurant>(); }
        }

        [ParseFieldName("Event")]
        public Event Event
        {
            set { SetProperty<Event>(value); }
            get { return GetProperty<Event>(); }
        }
    }
}