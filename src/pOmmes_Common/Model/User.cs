using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace pOmmes.Common
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
                using (SHA512 shaM = new SHA512Managed())
                {
                    var bytes = shaM.ComputeHash(Encoding.UTF8.GetBytes(value)).ToString();
                    foreach (byte x in bytes)
                    {
                        password += String.Format("{0:x2}", x);
                    }
                }
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

        //--------------------------------------------------------------------------
        //-- Methods static
        //--------------------------------------------------------------------------
        public static User CurrentUser
        {
            get;
            private set;
        }

        public static void Login(string userName, string password)
        {

        }

        public static void Logout(User user)
        {

        }

        public static void Register(User user)
        {

        }

        public static void RequestPasswordReset(string email)
        {

        }
    }
}
