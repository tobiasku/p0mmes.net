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
            InitializeComponent();
            EventBus.Instance.Register(this);

            this.eventObject = eventObject;
            MakeOrder(eventObject);
        }
        private async void MakeOrder(Event eventObject)
        {
            Restaurant restaurant = await eventObject.Restaurant.Query.FirstAsync();

            var query = new ParseQuery<Order>().WhereEqualTo("user", ParseUser.CurrentUser).WhereEqualTo("event", eventObject).WhereEqualTo("restaurant", restaurant);
            order = await query.FirstAsync();

            if (order != null)
            {

            }
            else
            {
                order = new Order();
                order.Event.Add(eventObject);
                order.User.Add(ParseUser.CurrentUser);
                order.Restaurant.Add(restaurant);
                await order.SaveAsync();
            }
        }

        private void FoodUserControl_Load(object sender, EventArgs e)
        {
            FillFoodList();
        }

        private async void FillFoodList()
        {
            Restaurant restaurant = eventObject.Restaurant.Query.FirstAsync().Result;

            mlbl_Restaurant.Text = restaurant.Name;

            var query = new ParseQuery<Article>().WhereEqualTo("Restaurant", restaurant);
            IEnumerable<Article> articleCollection = await query.FindAsync();

            Dictionary<string, int> locationDic = new Dictionary<string, int>();

            foreach (Article article in articleCollection)
            {
                Category category = article.Category.Query.FirstAsync().Result;

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
                Category category = control.article.Category.Query.FirstAsync().Result;

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
            actualFoodDetailUserControl.Dispose();
            actualFoodDetailUserControl = null;
            actualFoodObject = null;
        }

        //private async void mbtn_order_Click(object sender, EventArgs e)
        //{
        //    foreach (OrderPosition orderPosition in orderPositions)
        //    {
        //        orderPosition.Order.Add(order);
        //        await orderPosition.SaveAsync();
        //    }
        //}
    }
}