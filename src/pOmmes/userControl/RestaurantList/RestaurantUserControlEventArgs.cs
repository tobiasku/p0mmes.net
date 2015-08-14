using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes
{
    public class RestaurantUserControlEventArgs
    {
        private Restaurant restaurant = null;
        public Restaurant Restaurant { get { return restaurant; } private set { this.restaurant = value; } }

        public RestaurantUserControlEventArgs(Restaurant restaurant)
        {
            this.restaurant = restaurant;
        }
    }
}
