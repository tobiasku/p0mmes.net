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
        public string ObjectId
        {
            get;
            private set;
        }

        public DateTime? UpdatedAt
        {
            get;
            private set;
        }

        public DateTime? CreatedAt
        {
            get;
            private set;
        }
    }
}
