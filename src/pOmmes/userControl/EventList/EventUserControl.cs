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
using pOmmes.Common;
using MetroFramework.Controls;
using pOmmes.Data;
using pOmmes.Common.Dic;

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

        private void FillEventList()
        {
            IpOmmesDataBL pOmmesDataBL = Dic.Get<IpOmmesDataBL>();
            Collection<Event> eventCollection = pOmmesDataBL.Get<Event>();

            int location = 0;
            foreach (Event poEvent in eventCollection)
            {
                switch (poEvent.EventState)
                {
                    case EventState.Closed:
                        if (poEvent.UserCreated.ObjectId == User.CurrentUser.ObjectId)
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
