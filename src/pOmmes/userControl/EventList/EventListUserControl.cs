using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Controls;
using pOmmes.Data;
using Parse;

namespace pOmmes
{
    public partial class EventListUserControl : MetroUserControl
    {
        private Event pevent;

        public EventListUserControl(Event pevent)
        {
            this.pevent = pevent;

            InitializeComponent();
        }

        private void EventListUserControl_Load(object sender, EventArgs e)
        {
            SetEventListItem(pevent);
        }

        private async void SetEventListItem(Event pevent)
        {
            if (pevent != null)
            {
                mlbl_name.Text = pevent.Name;
                if (pevent.Restaurant != null)
                {
                    try
                    {
                        Restaurant restaurant = await pevent.Restaurant.FetchAsync();
                        if (restaurant != null)
                        {
                            mlbl_restaurant.Text = restaurant.Name;
                        }
                    }
                    catch (ParseException)
                    {
                    }
                }

                switch ((EventState)pevent.EventState)
                {
                    case EventState.Edit:
                        pic_state.Image = Resources.pOmmes_Resources.ic_create_black_48dp;
                        mlbl_description.Text = "Not published";
                        break;
                    case EventState.Vote:
                        pic_state.Image = Resources.pOmmes_Resources.ic_announcement_black_48dp;
                        mlbl_description.Text = "Please vote to: " + pevent.DateToVote.ToString("dd.MM.yy - hh.mm.ss");
                        break;
                    case EventState.Order:
                        pic_state.Image = Resources.pOmmes_Resources.ic_announcement_black_48dp;
                        mlbl_description.Text = "Please order to: " + pevent.DateToVote.ToString("dd.MM.yy - hh.mm.ss");
                        break;
                    case EventState.ReadyToSent:
                        pic_state.Image = Resources.pOmmes_Resources.ic_input_black_48dp;
                        mlbl_description.Text = "Please place order at restaurant";
                        break;
                    case EventState.Sent:
                        pic_state.Image = Resources.pOmmes_Resources.ic_done_black_48dp;
                        mlbl_description.Text = "Sent to restaurant";
                        break;
                    case EventState.Closed:
                        pic_state.Image = Resources.pOmmes_Resources.ic_block_black_48dp;
                        mlbl_description.Text = "Event closed";
                        break;
                    default:
                        pic_state.Image = null;
                        mlbl_description.Text = "";
                        break;
                }
            }
            else
            {
                throw new ArgumentNullException("pevent");
            }
        }

        public event EventHandler<EventUserControlEventArgs> EventListUserControl_Clicked;

        private void ThrowEventListUserControl_Clicked(MouseButton button)
        {
            if (EventListUserControl_Clicked != null)
            {
                this.EventListUserControl_Clicked(this, new EventUserControlEventArgs(this.pevent, button));
            }
        }

        private void EventListUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e != null)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        ThrowEventListUserControl_Clicked(MouseButton.Left);
                        break;
                    case MouseButtons.Middle:
                        ThrowEventListUserControl_Clicked(MouseButton.Middle);
                        break;
                    case MouseButtons.Right:
                        ThrowEventListUserControl_Clicked(MouseButton.Right);
                        break;
                    case MouseButtons.None:
                        ThrowEventListUserControl_Clicked(MouseButton.None);
                        break;
                }
            }
        }
    }
}
