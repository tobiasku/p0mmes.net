
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pOmmes
{
    public class FoodControlChangeEvent
    {
        public FoodBasketUserControl FoodBasketControl { get; private set; }
        public FoodDetailUserControl FoodDetailControl { get; private set; }
        public UserControlChangeState State { get; private set; }

        public FoodControlChangeEvent(FoodDetailUserControl control, UserControlChangeState state)
        {
            this.State = state;
            this.FoodDetailControl = control;
        }

        public FoodControlChangeEvent(FoodBasketUserControl control, UserControlChangeState state)
        {
            this.State = state;
            this.FoodBasketControl = control;
        }
    }
}
