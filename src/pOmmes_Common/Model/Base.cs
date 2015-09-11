using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pOmmes.Common
{
    public abstract class Base
    {
        public string _id
        {
            get;
            set;
        }

        public DateTime? UpdatedAt
        {
            get;
            set;
        }

        public DateTime? CreatedAt
        {
            get;
            set;
        }
    }
}
