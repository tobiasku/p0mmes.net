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
using MetroFramework;

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
                        contr.RestaurantListUserControl_Clicked += Contr_RestaurantListUserControl_Clicked;
                        this.mtp_RestaurantList.Controls.Add(contr);

                        location += contr.Size.Height;
                    }));
                }
            }));
        }

        private void Contr_RestaurantListUserControl_Clicked(object sender, RestaurantUserControlEventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this.Parent.Parent, "Möchten sie für " + e.Restaurant.Name + " stimmen?", "Abstimmung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.OK:
                    EventBus.Instance.PostEvent(new UserControlChangeEvent(null, UserControlChangeState.Pop));
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
