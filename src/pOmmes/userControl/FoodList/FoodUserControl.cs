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
using pOmmes.Common;
using MetroFramework.Controls;
using System.Threading;
using pOmmes.Data;

namespace pOmmes
{
    public partial class FoodUserControl : MetroUserControl
    {
        Restaurant restaurant;
        private Collection<OrderPosition> orderPositions = new Collection<OrderPosition>();

        public FoodUserControl(Restaurant restaurant)
        {
            this.restaurant = restaurant;
            InitializeComponent();
            EventBus.Instance.Register(this);
        }

        private void FoodUserControl_Load(object sender, EventArgs e)
        {
            FillFoodList();
        }

        private void FillFoodList()
        {
            mlbl_Restaurant.Text = restaurant.Name;

            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                Dictionary<string, object> filter = new Dictionary<string, object>();
                filter.Add("Restaurant", restaurant._id);
                Collection<Article> articleCollection = Dic.Get<IpOmmesDataBL>().Get<Article>(filter);

                Dictionary<string, int> locationDic = new Dictionary<string, int>();

                foreach (Article article in articleCollection)
                {
                    this.mtc_FoodList.Invoke(new Action(delegate ()
                    {
                        if (!mtc_FoodList.TabPages.ContainsKey(article.Category._id))
                        {
                            locationDic.Add(article.Category._id, 0);
                            mtc_FoodList.TabPages.Add(article.Category._id, article.Category.Name);
                        }

                        FoodListUserControl contr = new FoodListUserControl(article);
                        contr.FoodDetailUserControl_Select += Contr_FoodDetailUserControl_Select;
                        contr.Location = new Point(0, locationDic[article.Category._id]);
                        this.mtc_FoodList.TabPages[article.Category._id].Controls.Add(contr);

                        locationDic[article.Category._id] += contr.Size.Height;
                    }));
                }
            }));
        }

        private void Contr_FoodDetailUserControl_Select(object sender, FoodDetailUserControlEventArgs e)
        {
            if (orderPositions != null)
            {
                orderPositions.Add(e.OrderPosition);
            }

            if (orderPositions.Count > 0)
            {
                mbtn_order.Visible = true;
                mbtn_order.Text = orderPositions.Count.ToString();
            }
            else
            {
                mbtn_order.Visible = false;
                mbtn_order.Text = "";
            }
        }

        FoodDetailUserControl actualFoodDetailUserControl;
        string actualFoodObject;
        
        public void OnEvent(FoodDetailChangeEvent e)
        {
            switch (e.State)
            {
                case UserControlChangeState.Pop:
                    PopUserControl();
                    break;
                case UserControlChangeState.Push:
                    PushUserControl(e.Control);
                    break;
            }
        }

        private void PushUserControl(FoodDetailUserControl control)
        {
            if (actualFoodDetailUserControl != null)
            {
                PopUserControl();
            }

            if (control != null)
            {
                control.Location = new Point((this.Size.Width / 2 - control.Size.Width / 2), (this.Size.Height / 2 - control.Size.Height / 2));
                this.mtc_FoodList.TabPages[control.article.Category._id].Controls.Add(control);
                control.BringToFront();
                this.actualFoodObject = control.article.Category._id;
                this.actualFoodDetailUserControl = control;
            }
        }

        private void PopUserControl()
        {
            if (actualFoodDetailUserControl != null)
            {
                this.mtc_FoodList.TabPages[actualFoodObject].Controls.Remove(actualFoodDetailUserControl);
            }
            actualFoodDetailUserControl.Dispose();
            actualFoodDetailUserControl = null;
            actualFoodObject = null;
        }

        private void mbtn_order_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.OrderPositions = orderPositions;
        }
    }
}