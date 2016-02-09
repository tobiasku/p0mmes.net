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

        public static Collection<User> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<User>();
        }

        public static Collection<User> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<User>(filter);
        }

        public static User Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<User>(objectId);
        }

        public static void Put(Collection<User> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<User>(collectionToPut);
        }

        public static void Post(Collection<User> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<User>(collectionToPost);
        }

        public static void Delete(Collection<User> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<User>(collectionToDelete);
        }
    }
}
