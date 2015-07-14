using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes_Data
{
    public abstract class Base
    {
        string _Id
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
        }

        DateTime? CreatedAt
        {
            get;
        }
    }
}
