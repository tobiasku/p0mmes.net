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
        private Event pEvent = null;
        private Restaurant restaurant = null;

        public Restaurant Restaurant { get { return restaurant; } private set { this.restaurant = value; } }
        public Event Event { get { return pEvent; } private set { this.pEvent = value; } }

        public RestaurantUserControlEventArgs(Restaurant restaurant, Event pEvent)
        {
            this.pEvent = pEvent;
            this.restaurant = restaurant;
        }
    }
}
