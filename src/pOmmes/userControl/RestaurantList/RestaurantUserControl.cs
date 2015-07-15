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
using pOmmes.Common;
using pOmmes.Data;
using pOmmes.Common.Dic;

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

        private void FillRestaurantList()
        {
            IpOmmesDataBL pOmmesDataBL = Dic.Get<IpOmmesDataBL>();
            Collection<Restaurant> restaurantCollection = pOmmesDataBL.Get<Restaurant>();

            int location = 0;
            foreach (Restaurant poRestaurant in restaurantCollection)
            {
                RestaurantListUserControl contr = new RestaurantListUserControl(poRestaurant);
                contr.Location = new Point(0, location);
                this.mtp_RestaurantList.Controls.Add(contr);

                location += contr.Size.Height;
            }
        }
    }
}
