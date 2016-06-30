
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
        public Event Event
        {
            get { return pevent; }
            private set { this.pevent = value; }
        }

        private MouseButton mouseButton = MouseButton.None;
        public MouseButton MouseButton
        {
            get { return mouseButton; }
            private set { mouseButton = value; }
        }

        public EventUserControlEventArgs(Event pevent, MouseButton button)
        {
            this.pevent = pevent;
            this.mouseButton = button;
        }


    }

    public enum MouseButton
    {
        Left,
        Right,
        Middle,
        None,
    }
}
