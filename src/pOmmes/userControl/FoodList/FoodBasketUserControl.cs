using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pOmmes.Common;
using MetroFramework.Controls;
using System.Collections.ObjectModel;
using pOmmes.Common.Dic;
using pOmmes.Data;

namespace pOmmes
{
    public partial class FoodBasketUserControl : MetroUserControl
    {
        private Order order;
        private Collection<OrderPosition> orderPositions;

        public FoodBasketUserControl(Collection<OrderPosition> orderPositions, Order order)
        {
            InitializeComponent();
            this.order = order;
            this.orderPositions = orderPositions;
        }

        private void FoodBasketUserControl_Load(object sender, EventArgs e)
        {
            SetFoodBasketUserControl();
        }

        private void SetFoodBasketUserControl()
        {
            this.mg_orderdata.DataSource = orderPositions;
        }

        private void mlink_Close_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(this, UserControlChangeState.Pop));
        }

        private void mbtn_order_Click(object sender, EventArgs e)
        {
            ThrowFoodBasketUserControl_Order(new FoodBasketUserControlEventArgs(order));
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(this, UserControlChangeState.Pop));
        }

        public event EventHandler<FoodBasketUserControlEventArgs> FoodBasketUserControl_Order;

        private void ThrowFoodBasketUserControl_Order(FoodBasketUserControlEventArgs eventArgs)
        {
            if (FoodBasketUserControl_Order != null)
            {
                this.FoodBasketUserControl_Order(this, eventArgs);
            }
        }
    }
}
