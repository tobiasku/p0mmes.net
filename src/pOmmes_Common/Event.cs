using Parse;
using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    [ParseClassName("Event")]
    public class Event : ParseObject
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


        [ParseFieldName("Company")]
        public ParseRelation<Company> Company
        {
            set { SetProperty<ParseRelation<Company>>(value); }
            get { return GetRelationProperty<Company>(); }
        }

        [ParseFieldName("Restaurant")]
        public ParseRelation<Restaurant> Restaurant
        {
            set { SetProperty<ParseRelation<Restaurant>>(value); }
            get { return GetRelationProperty<Restaurant>(); }
        }

        [ParseFieldName("DateToOrder")]
        public DateTime DateToOrder
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("DateToVote")]
        public DateTime DateToVote
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("Name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("EventType")]
        public int EventType
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }

        [ParseFieldName("EventState")]
        public int EventState
        {
            get { return GetProperty<int>(); }
            set { SetProperty<int>(value); }
        }
    }
}
