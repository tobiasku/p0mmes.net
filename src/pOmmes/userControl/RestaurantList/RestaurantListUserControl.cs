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
using pOmmes.Data;
using System.IO;

namespace pOmmes
{
    public partial class RestaurantListUserControl : MetroUserControl
    {
        private Restaurant restaurant;
        private Event pEvent;

        public RestaurantListUserControl(Restaurant restaurant, Event pEvent)
        {
            this.restaurant = restaurant;
            this.pEvent = pEvent;

            InitializeComponent();
        }

        private void RestaurantListUserControl_Load(object sender, EventArgs e)
        {
            SetRestaurantListItem();
        }

        private void SetRestaurantListItem()
        {
            mlbl_name.Text = restaurant.Name;
            mlbl_phone.Text = restaurant.PhoneNumber;

            try
            {
                if (!string.IsNullOrEmpty(restaurant.LogoURL))
                {
                    try
                    {
                        pic_state.Load(restaurant.LogoURL);
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {

            }
        }

        public event EventHandler<RestaurantUserControlEventArgs> RestaurantListUserControl_Clicked;

        private void ThrowRestaurantListUserControl_Clicked()
        {
            if (RestaurantListUserControl_Clicked != null)
            {
                this.RestaurantListUserControl_Clicked(this, new RestaurantUserControlEventArgs(this.restaurant, this.pEvent));
            }
        }

        private void RestaurantListUserControl_Click(object sender, EventArgs e)
        {
            ThrowRestaurantListUserControl_Clicked();
        }
    }
}
