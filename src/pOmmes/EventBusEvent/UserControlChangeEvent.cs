using pOmmes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pOmmes.Data
{
    public class UserControlChangeEvent
    {
        public UserControl Control { get; private set; }
        public UserControlChangeState State { get; private set; }

        public UserControlChangeEvent(UserControl control, UserControlChangeState state)
        {
            this.State = state;
            this.Control = control;
        }
    }
}
