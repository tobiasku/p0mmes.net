using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class Event : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public User UserCreated
        {
            get;
            set;
        }

        public Company Company
        {
            get;
            set;
        }

        public Restaurant Restaurant
        {
            get;
            set;
        }

        public DateTime DateToOrder
        {
            get;
            set;
        }

        public DateTime DateToVote
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public EventType EventType
        {
            get;
            set;
        }

        public EventState EventState
        {
            get;
            set;
        }

        public Collection<Vote> Votes
        {
            get;
            set;
        }

        public Collection<Order> Orders
        {
            get;
            set;
        }
    }
}
