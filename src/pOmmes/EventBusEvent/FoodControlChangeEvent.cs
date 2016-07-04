
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
        public UserControl UserControl { get; private set; }
        public UserControlChangeState State { get; private set; }

        public FoodControlChangeEvent(UserControl control, UserControlChangeState state)
        {
            this.State = state;
            this.UserControl = control;
        }
    }
}
