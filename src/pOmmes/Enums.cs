using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public enum EventType
    {
        VoteEvent = 1,
        StaticEvent = 2,
    }

    public enum EventState
    {
        Edit = 1,
        Vote = 2,
        Order = 3,
        ReadyToSent = 4,
        Sent = 5,
        Closed = 6,
    }

    public enum UserControlChangeState
    {
        Pop = 1,
        Push = 2,
    }
}
