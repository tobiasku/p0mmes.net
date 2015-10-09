using pOmmes.Common;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public class EventUserControlEventArgs
    {
        private Event pevent = null;
        public Event Event { get { return pevent; } private set { this.pevent = value; } }

        public EventUserControlEventArgs(Event pevent)
        {
            this.pevent = pevent;
        }
    }
}
