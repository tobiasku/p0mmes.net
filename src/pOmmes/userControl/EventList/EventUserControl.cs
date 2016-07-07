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
using MetroFramework.Controls;
using pOmmes.Data;
using System.Threading;
using Parse;
using MetroFramework;

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
            this.mpnl_refreshButton.Visible = false;
            this.mps_spinner.Visible = true;            

            var query = new ParseQuery<Event>();
            IEnumerable<Event> eventCollection = await query.FindAsync();

            this.mtp_EventList.Invoke(new Action(delegate ()
            {
                foreach (Control control in mtp_EventList.Controls)
                {
                    mtp_EventList.Controls.Remove(control);
                    control.Dispose();
                }
            }));

            int location = 0;
            foreach (Event poEvent in eventCollection)
            {
                ParseUser user = null;
                try
                {
                    user = await poEvent.User.FetchAsync();
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

            this.mpnl_refreshButton.Visible = true;
            this.mps_spinner.Visible = false;
        }

        private async void EventListUserControl_Clicked(object sender, EventUserControlEventArgs e)
        {
            switch ((EventState)e.Event.EventState)
            {
                case EventState.Edit:
                    break;
                case EventState.Vote:
                    if (e.Event != null)
                    {
                        if (DateTime.Now <= e.Event.DateToVote)
                        {
                            var votesQuery = from votes in new ParseQuery<Vote>()
                                             where votes["Event"] == e.Event && votes["User"] == ParseUser.CurrentUser
                                             select votes;
                            IEnumerable<Vote> voteCollection = await votesQuery.FindAsync();

                            if (voteCollection != null && voteCollection.Count() > 0)
                            {
                                DialogResult result = MetroMessageBox.Show(this.Parent.Parent, "Sie haben bereits einmal abgestimmt!", "Abstimmung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                switch (result)
                                {
                                    case DialogResult.OK:
                                        break;
                                    case DialogResult.Cancel:
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                RestaurantUserControl restaurantUserControl = new RestaurantUserControl(e.Event);
                                restaurantUserControl.RestaurantUserControl_Select += RestaurantUserControl_RestaurantUserControl_Select;
                                EventBus.Instance.PostEvent(new UserControlChangeEvent(restaurantUserControl, UserControlChangeState.Push));
                            }
                        }
                        else
                        {
                            DialogResult result = MetroMessageBox.Show(this.Parent.Parent, "Die Zeit um für das Restaurant abzustimmen ist bereits vorbei.", "Abstimmung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            switch (result)
                            {
                                case DialogResult.OK:
                                    break;
                                case DialogResult.Cancel:
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case EventState.Order:
                    if (e.Event != null)
                    {
                        if (e.Event.Restaurant == null)
                        {
                            var votesQuery = from votes in new ParseQuery<Vote>()
                                             where votes["Event"] == e.Event
                                             select votes;
                            IEnumerable<Vote> voteCollection = await votesQuery.FindAsync();

                            Dictionary<Restaurant, int> restaurantDic = new Dictionary<Restaurant, int>();

                            if (voteCollection != null && voteCollection.Count() > 0)
                            {
                                foreach (Vote vote in voteCollection)
                                {
                                    if (restaurantDic.ContainsKey(vote.Restaurant))
                                    {
                                        restaurantDic[vote.Restaurant] += 1;
                                    }
                                    else
                                    {
                                        restaurantDic.Add(vote.Restaurant, 1);
                                    }
                                }
                            }

                            if (restaurantDic != null && restaurantDic.Count > 0)
                            {
                                Collection<KeyValuePair<Restaurant, int>> highestCollection = new Collection<KeyValuePair<Restaurant, int>>();
                                foreach (KeyValuePair<Restaurant, int> restaurant in restaurantDic)
                                {
                                    if (highestCollection.Count > 0)
                                    {
                                        foreach (KeyValuePair<Restaurant, int> restaurantTemp in highestCollection)
                                        {
                                            if (restaurantTemp.Value > restaurant.Value)
                                            {
                                                highestCollection.Clear();
                                                highestCollection.Add(restaurant);
                                            }
                                            else if (restaurantTemp.Value == restaurant.Value)
                                            {
                                                highestCollection.Add(restaurant);
                                            }
                                            else
                                            {
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        highestCollection.Add(restaurant);
                                    }
                                }

                                if (highestCollection.Count > 0)
                                {
                                    if (highestCollection.Count == 1)
                                    {
                                        e.Event.Restaurant = highestCollection.First().Key;
                                        await e.Event.SaveAsync();
                                    }
                                    else
                                    {
                                        //TODO: Random
                                    }
                                }
                                else
                                {
                                    //TODO: Error
                                }
                            }
                            else
                            {
                                //TODO: Error
                            }
                        }

                        if (e.Event.Restaurant != null)
                        {
                            FoodUserControl foodUserControl = new FoodUserControl(e.Event);
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
                vote.Restaurant = e.Restaurant;
                vote.User = ParseUser.CurrentUser;
                vote.Event = e.Event;

                await vote.SaveAsync();

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

        private void mPnl_Main_Click(object sender, EventArgs e)
        {
            FillEventList();
        }
    }
}
