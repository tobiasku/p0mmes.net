using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pOmmes.Common;
using MetroFramework.Controls;

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
            SetEventListItem();
        }

        private void SetEventListItem()
        {
            mlbl_name.Text = pevent.Name;
            if (pevent.Restaurant != null)
            {
                mlbl_restaurant.Text = pevent.Restaurant.Name;
            }

            switch (pevent.EventState)
            {
                case EventState.Edit:
                    pic_state.Image = global::pOmmes.Properties.Resources.ic_create_black_48dp;
                    mlbl_description.Text = "Not published";
                    break;
                case EventState.Vote:
                    pic_state.Image = global::pOmmes.Properties.Resources.ic_announcement_black_48dp;
                    mlbl_description.Text = "Please vote to: " + pevent.DateToVote.ToString("dd.MM.yy - hh.mm.ss");
                    break;
                case EventState.Order:
                    pic_state.Image = global::pOmmes.Properties.Resources.ic_announcement_black_48dp;
                    mlbl_description.Text = "Please order to: " + pevent.DateToVote.ToString("dd.MM.yy - hh.mm.ss");
                    break;
                case EventState.ReadyToSent:
                    pic_state.Image = global::pOmmes.Properties.Resources.ic_input_black_48dp;
                    mlbl_description.Text = "Please place order at restaurant";
                    break;
                case EventState.Sent:
                    pic_state.Image = global::pOmmes.Properties.Resources.ic_done_black_48dp;
                    mlbl_description.Text = "Sent to restaurant";
                    break;
                case EventState.Closed:
                    pic_state.Image = global::pOmmes.Properties.Resources.ic_block_black_48dp;
                    mlbl_description.Text = "Event closed";
                    break;
                default:
                    pic_state.Image = null;
                    mlbl_description.Text = "";
                    break;
            }
        }

        public event EventHandler<EventUserControlEventArgs> EventListUserControl_Clicked;

        private void ThrowEventListUserControl_Clicked()
        {
            if (EventListUserControl_Clicked != null)
            {
                this.EventListUserControl_Clicked(this, new EventUserControlEventArgs(this.pevent));
            }
        }

        private void EventListUserControl_Click(object sender, EventArgs e)
        {
            ThrowEventListUserControl_Clicked();
        }
    }
}
