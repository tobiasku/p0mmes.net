using pOmmes_Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class Event : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        User UserCreated
        {
            get;
            set;
        }

        Company Company
        {
            get;
            set;
        }

        Restaurant Restaurant
        {
            get;
            set;
        }

        DateTime DateToOrder
        {
            get;
            set;
        }

        DateTime DateToVote
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        EventType EventType
        {
            get;
            set;
        }

        EventState EventState
        {
            get;
            set;
        }

        Collection<Vote> Votes
        {
            get;
            set;
        }

        Collection<Order> Orders
        {
            get;
            set;
        }
    }
}
