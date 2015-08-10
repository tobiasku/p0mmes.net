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
using System.Threading;

namespace pOmmes
{
    public partial class RestaurantUserControl : MetroUserControl
    {
        private IpOmmesDataBL pOmmesData = null;

        public RestaurantUserControl()
        {
            InitializeComponent();

            this.pOmmesData = Dic.Get<IpOmmesDataBL>();
        }

        private void RestaurantUserControl_Load(object sender, EventArgs e)
        {
            FillRestaurantList();
        }

        private void FillRestaurantList()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                Collection<Restaurant> restaurantCollection = pOmmesData.Get<Restaurant>();

                int location = 0;
                foreach (Restaurant poRestaurant in restaurantCollection)
                {
                    this.mtp_RestaurantList.Invoke(new Action(delegate ()
                    {
                        RestaurantListUserControl contr = new RestaurantListUserControl(poRestaurant);
                        contr.Location = new Point(0, location);
                        this.mtp_RestaurantList.Controls.Add(contr);

                        location += contr.Size.Height;
                    }));
                }
            }));
        }
    }
}
