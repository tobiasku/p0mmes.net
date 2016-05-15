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
using System.Threading;
using Parse;

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

        private async void FillEventList()
        {
            var query = new ParseQuery<Event>();
            IEnumerable<Event> eventCollection = await query.FindAsync();

            int location = 0;
            foreach (Event poEvent in eventCollection)
            {
                ParseUser user = null;
                try
                {
                    user = await poEvent.User.Query.FirstAsync();
                }
                catch (ParseException)
                {
                }


                switch ((EventState)poEvent.EventState)
                {
                    case EventState.Closed:
                        if (user != null && user == ParseUser.CurrentUser)
                        {
                            goto default;
                        }
                        break;
                    default:
                        this.mtp_EventList.Invoke(new Action(delegate ()
                        {
                            EventListUserControl contr = new EventListUserControl(poEvent);
                            contr.Location = new Point(0, location);
                            contr.EventListUserControl_Clicked += EventListUserControl_Clicked;
                            this.mtp_EventList.Controls.Add(contr);

                            location += contr.Size.Height;
                        }));
                        break;
                }
            }
        }

        private void EventListUserControl_Clicked(object sender, EventUserControlEventArgs e)
        {
            switch ((EventState)e.Event.EventState)
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

        private async void RestaurantUserControl_RestaurantUserControl_Select(object sender, RestaurantUserControlEventArgs e)
        {
            if (e.Event != null && e.Restaurant != null)
            {
                Vote vote = new Vote();
                vote.Restaurant.Add(e.Restaurant);
                vote.User.Add(ParseUser.CurrentUser);
                vote.Event.Add(e.Event);

                await vote.SaveAsync();
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
