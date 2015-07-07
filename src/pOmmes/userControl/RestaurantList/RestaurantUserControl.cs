using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parse;
using System.Collections.ObjectModel;
using MetroFramework.Controls;

namespace pOmmes
{
    public partial class RestaurantUserControl : MetroUserControl
    {
        public RestaurantUserControl()
        {
            InitializeComponent();
        }

        private void RestaurantUserControl_Load(object sender, EventArgs e)
        {
            FillRestaurantList();
        }

        private async void FillRestaurantList()
        {
            ParseQuery<ParseRestaurant> restaurantQuery = new ParseQuery<ParseRestaurant>();
            Collection<ParseRestaurant> restaurantCollection = new Collection<ParseRestaurant>((await restaurantQuery.FindAsync()).ToList<ParseRestaurant>());

            int location = 0;
            foreach (ParseRestaurant poRestaurant in restaurantCollection)
            {
                RestaurantListUserControl contr = new RestaurantListUserControl(poRestaurant);
                contr.Location = new Point(0, location);
                this.mtp_RestaurantList.Controls.Add(contr);

                location += contr.Size.Height;
            }
        }
    }
}
