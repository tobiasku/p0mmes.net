using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes_Data
{
    public class User : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        string UserName
        {
            get;
            set;
        }

        string ForeName
        {
            get;
            set;
        }

        string SurName
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }

        string Password
        {
            set;
            get;
        }

        Company Company
        {
            get;
            set;
        }

        Role Role
        {
            get;
            set;
        }
    }
}
