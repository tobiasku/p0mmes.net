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
        public ParseRelation<ParseUser> User
        {
            set { SetProperty<ParseRelation<ParseUser>>(value); }
            get { return GetRelationProperty<ParseUser>(); }
        }

        [ParseFieldName("Restaurant")]
        public ParseRelation<Restaurant> Restaurant
        {
            set { SetProperty<ParseRelation<Restaurant>>(value); }
            get { return GetRelationProperty<Restaurant>(); }
        }

        [ParseFieldName("Event")]
        public ParseRelation<Event> Event
        {
            set { SetProperty<ParseRelation<Event>>(value); }
            get { return GetRelationProperty<Event>(); }
        }
    }
}