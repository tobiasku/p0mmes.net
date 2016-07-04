using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pOmmes.Data;

namespace pOmmes
{
    public partial class FoodBasketUserControl : UserControl
    {
        private Order order;
        private List<OrderPosition> orderPositions;

        public FoodBasketUserControl(IEnumerable<OrderPosition> orderPositions, Order order)
        {
            this.order = order;
            this.orderPositions = orderPositions.ToList();
            InitializeComponent();
        }

        private void FoodBasketUserControl_Load(object sender, EventArgs e)
        {
            SetFoodBasketUserControl();
        }

        private void SetFoodBasketUserControl()
        {
        }

        private void mlink_Close_Click(object sender, EventArgs e)
        {
            EventBus.Instance.PostEvent(new FoodControlChangeEvent(this, UserControlChangeState.Pop));
        }

        private void mbtn_order_Click(object sender, EventArgs e)
        {
            ThrowFoodBasketUserControl_Order(new FoodBasketUserControlEventArgs(order));
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
