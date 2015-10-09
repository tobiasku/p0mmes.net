using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace pOmmes.Data
{
    public class User : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string UserName
        {
            get;
            set;
        }

        public string ForeName
        {
            get;
            set;
        }

        public string SurName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        private string password;
        public string Password
        {
            set
            {
                password = value;
                //using (SHA512 shaM = new SHA512Managed())
                //{
                //    var bytes = shaM.ComputeHash(Encoding.UTF8.GetBytes(value)).ToString();
                //    foreach (byte x in bytes)
                //    {
                //        password += String.Format("{0:x2}", x);
                //    }
                //}
            }
            get { return password; }
        }

        public Company Company
        {
            get;
            set;
        }

        public Role Role
        {
            get;
            set;
        }
    }
}
