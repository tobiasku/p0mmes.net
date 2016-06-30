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
            MakeOrder(eventObject);
            FillFoodList();
        }

        private async void MakeOrder(Event eventObject)
        {
            Restaurant restaurant = await eventObject.Restaurant.FetchAsync();

            try
            {
                var query = new ParseQuery<Order>().WhereEqualTo("User", ParseUser.CurrentUser).WhereEqualTo("Event", eventObject).WhereEqualTo("Restaurant", restaurant);
                order = await query.FirstAsync();
            }
            catch (ParseException e)
            {

            }

            if (order != null)
            {

            }
            else
            {
                order = new Order();
                order.Event = eventObject;
                order.User = ParseUser.CurrentUser;
                order.Restaurant = restaurant;
                await order.SaveAsync();
            }
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

                    FoodListUserControl contr = new FoodListUserControl(article, order);
                    contr.FoodDetailUserControl_Select += Contr_FoodDetailUserControl_Select;
                    contr.Location = new Point(0, locationDic[category.ObjectId]);
                    this.mtc_FoodList.TabPages[category.ObjectId].Controls.Add(contr);

                    locationDic[category.ObjectId] += contr.Size.Height;
                }));
            }
        }

        private async void Contr_FoodDetailUserControl_Select(object sender, FoodDetailUserControlEventArgs e)
        {
            await order.FetchAsync();

            var query = new ParseQuery<OrderPosition>().WhereEqualTo("order", order);
            IEnumerable<OrderPosition> orderPositions = await query.FindAsync();

            if (orderPositions.Count() > 0)
            {
                mbtn_order.Visible = true;
                mbtn_order.Text = orderPositions.Count().ToString();
            }
            else
            {
                mbtn_order.Visible = false;
                mbtn_order.Text = "";
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
        FoodBasketUserControl actualFoodBasketUserControl;
        string actualFoodObject;

        public void OnEvent(FoodControlChangeEvent e)
        {
            switch (e.State)
            {
                case UserControlChangeState.Pop:
                    PopUserControl();
                    break;
                case UserControlChangeState.Push:
                    if (e.FoodBasketControl != null)
                    {
                        PushUserControl(e.FoodBasketControl);
                    }
                    else if (e.FoodDetailControl != null)
                    {
                        PushUserControl(e.FoodDetailControl);
                    }
                    break;
            }
        }

        private void PushUserControl(FoodBasketUserControl control)
        {
            if (actualFoodBasketUserControl != null)
            {
                PopUserControl();
            }

            if (control != null)
            {
                control.Location = new Point((this.Size.Width / 2 - control.Size.Width / 2), (this.Size.Height / 2 - control.Size.Height / 2));
                this.Controls.Add(control);
                control.BringToFront();
                this.actualFoodBasketUserControl = control;
            }
        }

        private async void PushUserControl(FoodDetailUserControl control)
        {
            if (actualFoodDetailUserControl != null)
            {
                PopUserControl();
            }

            if (control != null)
            {
                Category category = await control.article.Category.FetchAsync();

                control.Location = new Point((this.Size.Width / 2 - control.Size.Width / 2), (this.Size.Height / 2 - control.Size.Height / 2));
                this.mtc_FoodList.TabPages[category.ObjectId].Controls.Add(control);
                control.BringToFront();
                this.actualFoodObject = category.ObjectId;
                this.actualFoodDetailUserControl = control;
            }
        }

        private void PopUserControl()
        {
            if (actualFoodDetailUserControl != null)
            {
                this.mtc_FoodList.TabPages[actualFoodObject].Controls.Remove(actualFoodDetailUserControl);
            }
            if (actualFoodBasketUserControl != null)
            {
                this.Controls.Remove(actualFoodBasketUserControl);
            }
            actualFoodDetailUserControl.Dispose();
            actualFoodBasketUserControl.Dispose();
            actualFoodDetailUserControl = null;
            actualFoodBasketUserControl = null;

            actualFoodObject = null;
        }
    }
}