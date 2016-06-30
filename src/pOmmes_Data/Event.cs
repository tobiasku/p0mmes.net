using Parse;
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
        public ParseUser User
        {
            set { SetProperty<ParseUser>(value); }
            get { return GetProperty<ParseUser>(); }
        }

        [ParseFieldName("Company")]
        public Company Company
        {
            set { SetProperty<Company>(value); }
            get { return GetProperty<Company>(); }
        }

        [ParseFieldName("Restaurant")]
        public Restaurant Restaurant
        {
            set { SetProperty<Restaurant>(value); }
            get { return GetProperty<Restaurant>(); }
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
