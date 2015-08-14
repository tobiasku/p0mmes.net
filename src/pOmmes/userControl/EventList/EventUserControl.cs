﻿using System;
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
using System.Threading;

namespace pOmmes
{
    public partial class EventUserControl : MetroUserControl
    {
        public EventUserControl()
        {
            InitializeComponent();
        }

        private void EventUserControl_Load(object sender, EventArgs e)
        {
            FillEventList();
        }

        private void FillEventList()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                Collection<Event> eventCollection = Dic.Get<IpOmmesDataBL>().Get<Event>();

                int location = 0;
                foreach (Event poEvent in eventCollection)
                {
                    switch (poEvent.EventState)
                    {
                        case EventState.Closed:
                            if (poEvent.UserCreated._id == User.CurrentUser._id)
                            {
                                goto default;
                            }
                            break;
                        default:
                            this.mtp_EventList.Invoke(new Action(delegate ()
                            {
                                EventListUserControl contr = new EventListUserControl(poEvent);
                                contr.Location = new Point(0, location);
                                contr.EventListUserControl_Clicked += Contr_EventListUserControl_Clicked;
                                this.mtp_EventList.Controls.Add(contr);

                                location += contr.Size.Height;
                            }));
                            break;
                    }
                }
            }));
        }

        private void Contr_EventListUserControl_Clicked(object sender, EventUserControlEventArgs e)
        {
            switch (e.Event.EventState)
            {
                case EventState.Edit:
                    break;
                case EventState.Vote:
                    break;
                case EventState.Order:
                    break;
                case EventState.ReadyToSent:
                    break;
                case EventState.Sent:
                    break;
                case EventState.Closed:
                    break;
            }

            ThrowEventUserControl_Select(e);
        }

        public event EventHandler<EventUserControlEventArgs> EventUserControl_Select;

        private void ThrowEventUserControl_Select(EventUserControlEventArgs eventArgs)
        {
            if (EventUserControl_Select != null)
            {
                this.EventUserControl_Select(this, eventArgs);
            }
        }
    }
}
