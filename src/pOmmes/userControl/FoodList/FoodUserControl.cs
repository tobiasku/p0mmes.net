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
using pOmmes.Data;
using System.Threading;
using Parse;

namespace pOmmes
{
    public partial class FoodUserControl : MetroUserControl
    {
        Event eventObject;
        Order order;
        private Collection<OrderPosition> orderPositions = new Collection<OrderPosition>();

        public FoodUserControl(Event eventObject)
        {
            this.eventObject = eventObject;

            InitializeComponent();
        }

        private void FoodUserControl_Load(object sender, EventArgs e)
        {
            EventBus.Instance.Register(this);

            FillFoodList();
        }

        private async void FillFoodList()
        {
            Restaurant restaurant = await eventObject.Restaurant.FetchAsync();
            mlbl_Restaurant.Text = restaurant.Name;

            var query = new ParseQuery<Article>().WhereEqualTo("Restaurant", restaurant);
            IEnumerable<Article> articleCollection = await query.FindAsync();

            Dictionary<string, int> locationDic = new Dictionary<string, int>();

            foreach (Article article in articleCollection)
            {
                Category category = await article.Category.FetchAsync();

                this.mtc_FoodList.Invoke(new Action(delegate ()
                {
                    if (!mtc_FoodList.TabPages.ContainsKey(category.ObjectId))
                    {
                        locationDic.Add(category.ObjectId, 0);
                        mtc_FoodList.TabPages.Add(category.ObjectId, category.Name);
                    }

                    FoodListUserControl contr = new FoodListUserControl(article);
                    contr.FoodDetailUserControl_Select += Contr_FoodDetailUserControl_Select;
                    contr.Location = new Point(0, locationDic[category.ObjectId]);
                    this.mtc_FoodList.TabPages[category.ObjectId].Controls.Add(contr);

                    locationDic[category.ObjectId] += contr.Size.Height;
                }));
            }
        }


        private void Contr_FoodDetailUserControl_Select(object sender, FoodUserControlEventArgs e)
        {
            FoodDetailUserControl foodDetailUserControl = new FoodDetailUserControl(e.Article);
            foodDetailUserControl.FoodDetailUserControl_Select += FoodDetailUserControl_FoodDetailUserControl_Select;

            EventBus.Instance.PostEvent(new FoodControlChangeEvent(foodDetailUserControl, UserControlChangeState.Push));

            //await order.FetchAsync();

            //var query = new ParseQuery<OrderPosition>().WhereEqualTo("Order", order);
            //IEnumerable<OrderPosition> orderPositions = await query.FindAsync();

            //if (orderPositions.Count() > 0)
            //{
            //    mbtn_order.Visible = true;
            //    mbtn_order.Text = orderPositions.Count().ToString();
            //}
            //else
            //{
            //    mbtn_order.Visible = false;
            //    mbtn_order.Text = "";
            //}
        }

        private void FoodDetailUserControl_FoodDetailUserControl_Select(object sender, FoodDetailUserControlEventArgs e)
        {
            if (e != null)
            {
                if (e.OrderPosition != null)
                {
                    orderPositions.Add(e.OrderPosition);

                    EventBus.Instance.PostEvent(new FoodControlChangeEvent((FoodDetailUserControl)null, UserControlChangeState.Pop));
                }
            }
        }

        private void mbtn_order_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(new FoodBasketUserControl(orderPositions, null), UserControlChangeState.Push));
            //    foreach (OrderPosition orderPosition in orderPositions)
            //    {
            //        orderPosition.Order.Add(order);
            //        await orderPosition.SaveAsync();
            //    }
        }


        FoodDetailUserControl actualFoodDetailUserControl;
        public void OnEvent(FoodControlChangeEvent e)
        {
            switch (e.State)
            {
                case UserControlChangeState.Pop:
                    PopUserControl();
                    break;
                case UserControlChangeState.Push:
                    if (e.FoodDetailControl != null)
                    {
                        PushUserControl(e.FoodDetailControl);
                    }
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
                this.Controls.Add(control);
                control.BringToFront();
                this.actualFoodDetailUserControl = control;
            }
        }

        private void PopUserControl()
        {
            if (actualFoodDetailUserControl != null)
            {
                this.Controls.Remove(actualFoodDetailUserControl);
            }
            actualFoodDetailUserControl.Dispose();
            actualFoodDetailUserControl = null;
        }
    }
}