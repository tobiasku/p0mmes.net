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
using MetroFramework.Controls;

using pOmmes.Data;
using System.Threading;
using MetroFramework;
using Parse;

namespace pOmmes
{
    public partial class RestaurantUserControl : MetroUserControl
    {
        private Event pEvent;

        public RestaurantUserControl(Event pEvent)
        {
            InitializeComponent();
            
            this.pEvent = pEvent;
        }

        private void RestaurantUserControl_Load(object sender, EventArgs e)
        {
            FillRestaurantList();
        }

        private async void FillRestaurantList()
        {
            var query = new ParseQuery<Restaurant>();
            IEnumerable<Restaurant> restaurantCollection = await query.FindAsync();

            int location = 0;
            foreach (Restaurant poRestaurant in restaurantCollection)
            {
                this.mtp_RestaurantList.Invoke(new Action(delegate ()
                {
                    RestaurantListUserControl contr = new RestaurantListUserControl(poRestaurant, pEvent);
                    contr.Location = new Point(0, location);
                    contr.RestaurantListUserControl_Clicked += RestaurantListUserControl_Clicked;
                    this.mtp_RestaurantList.Controls.Add(contr);

                    location += contr.Size.Height;
                }));
            }
        }

        private void RestaurantListUserControl_Clicked(object sender, RestaurantUserControlEventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Möchten sie für " + e.Restaurant.Name + " stimmen?", "Abstimmung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.OK:
                    ThrowRestaurantUserControl_Select(e);
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }
        }

        public event EventHandler<RestaurantUserControlEventArgs> RestaurantUserControl_Select;

        private void ThrowRestaurantUserControl_Select(RestaurantUserControlEventArgs eventArgs)
        {
            if (RestaurantUserControl_Select != null)
            {
                this.RestaurantUserControl_Select(this, eventArgs);
            }
        }
    }
}
