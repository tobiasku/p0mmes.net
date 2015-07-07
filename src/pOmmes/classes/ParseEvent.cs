using Parse;
using pOmmes_Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pOmmes
{
    [ParseClassName("Event")]
    public class ParseEvent : ParseObject
    {
        [ParseFieldName("name")]
        public string Name
        {
            get { return GetProperty<string>(); }
            set { SetProperty<string>(value); }
        }

        [ParseFieldName("eventType")]
        public EventType EventType
        {
            get { return (EventType)GetProperty<int>(); }
            set { SetProperty<int>((int)value); }
        }

        [ParseFieldName("eventState")]
        public EventState EventState
        {
            get { return (EventState)GetProperty<int>(); }
            set { SetProperty<int>((int)value); }
        }

        [ParseFieldName("dateToVote")]
        public DateTime DateToVote
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("dateToOrder")]
        public DateTime DateToOrder
        {
            get { return GetProperty<DateTime>(); }
            set { SetProperty<DateTime>(value); }
        }

        [ParseFieldName("userId")]
        public ParseUser UserCreated
        {
            get { return (ParseUser)this["userId"]; }
            set { SetProperty<ParseUser>(value as ParseUser); }
        }

        [ParseFieldName("companyId")]
        public ParseCompany Company
        {
            get { return (ParseCompany)this["companyId"]; }
            set { SetProperty<ParseCompany>(value as ParseCompany); }
        }

        [ParseFieldName("restaurantId")]
        public ParseRestaurant Restaurant
        {
            get { return (ParseRestaurant)this["restaurantId"]; }
            set { SetProperty<ParseRestaurant>(value as ParseRestaurant); }
        }

        public Collection<ParseVote> Votes
        {
            get { return null; }
            set { }
        }

        public Collection<ParseOrder> Orders
        {
            get { return null; }
            set { }
        }        
    }
}
