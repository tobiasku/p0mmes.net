using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Common
{
    public class Restaurant : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public string LogoURL
        {
            get;
            set;
        }
    }
}
