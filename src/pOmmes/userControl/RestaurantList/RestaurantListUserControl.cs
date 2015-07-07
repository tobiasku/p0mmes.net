using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pOmmes_Common;
using MetroFramework.Controls;

namespace pOmmes
{
    public partial class RestaurantListUserControl : MetroUserControl
    {
        private ParseRestaurant restaurant;

        public RestaurantListUserControl(ParseRestaurant restaurant)
        {
            this.restaurant = restaurant;

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
            if (!string.IsNullOrEmpty(restaurant.LogoURL))
            {
                pic_state.Load(restaurant.LogoURL);
            }
        }

        private void RestaurantListUserControl_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new UserControlChangeEvent(new FoodUserControl(restaurant), UserControlChangeState.Push));
        }
    }
}
