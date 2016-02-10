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
                //Event.Post(new Collection<Event>() { new Event() { Name = "Fritten-Freitag", EventType = EventType.VoteEvent, EventState = EventState.Vote, DateToVote = DateTime.Now.AddDays(7), DateToOrder = DateTime.Now.AddDays(14) } });

                int location = 0;
                foreach (Event poEvent in Event.Get())
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
                    if (e.Event != null)
                    {
                        if (e.Event.Votes.FirstOrDefault(x => x.User == User.CurrentUser) != null)
                        {
                            RestaurantUserControl restaurantUserControl = new RestaurantUserControl(e.Event);
                            restaurantUserControl.RestaurantUserControl_Select += RestaurantUserControl_RestaurantUserControl_Select;
                            EventBus.Instance.PostEvent(new UserControlChangeEvent(restaurantUserControl, UserControlChangeState.Push));
                        }
                    }
                    break;
                case EventState.Order:
                    if (e.Event != null)
                    {
                        if (e.Event.Restaurant != null)
                        {
                            Order order = e.Event.Orders.FirstOrDefault(x => x.User == User.CurrentUser);

                            FoodUserControl foodUserControl = new FoodUserControl(e.Event.Restaurant,order);
                            EventBus.Instance.PostEvent(new UserControlChangeEvent(foodUserControl, UserControlChangeState.Push));
                        }
                    }
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

        private void RestaurantUserControl_RestaurantUserControl_Select(object sender, RestaurantUserControlEventArgs e)
        {
            if (e.Event != null)
            {
                if (e.Event.Votes == null)
                {
                    e.Event.Votes = new Collection<Vote>();
                }
                Vote vote = new Vote();
                vote.Restaurant = e.Restaurant;
                vote.User = User.CurrentUser;

                Vote.Post(new Collection<Vote>() { vote });

                e.Event.Votes.Add(vote);

                Event.Put(new Collection<Event>() { e.Event });

                EventBus.Instance.PostEvent(new UserControlChangeEvent(null, UserControlChangeState.Pop));
            }
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
