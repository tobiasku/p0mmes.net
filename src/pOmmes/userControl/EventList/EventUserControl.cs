using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Parse;
using pOmmes_Common;
using MetroFramework.Controls;

namespace pOmmes.userControl.EventList
{
    public partial class EventUserControl : MetroUserControl
    {
        public EventUserControl()
        {
            InitializeComponent();
        }

        private void EventUserControl_Load(object sender, EventArgs e)
        {

        }

        private async void FillEventList()
        {
            ParseQuery<ParseEvent> eventQuery = new ParseQuery<ParseEvent>();
            Collection<ParseEvent> eventCollection = new Collection<ParseEvent>((await eventQuery.FindAsync()).ToList<ParseEvent>());

            int location = 0;
            foreach (ParseEvent poEvent in eventCollection)
            {
                switch (poEvent.EventState)
                {
                    case EventState.Closed:
                        if (poEvent.UserCreated.ObjectId == ParseUser.CurrentUser.ObjectId)
                        {
                            goto default;
                        }
                        break;
                    default:
                        EventListUserControl contr = new EventListUserControl(poEvent);
                        contr.Location = new Point(0, location);
                        this.Controls.Add(contr);

                        location += contr.Size.Height;
                        break;
                }

            }
        }
    }
}
