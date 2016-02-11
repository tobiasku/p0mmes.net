using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Company : Base
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

        public static Collection<Company> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Company>();
        }

        public static Collection<Company> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Company>(filter);
        }

        public static Company Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Company>(objectId);
        }

        public void Put()
        {
            this.UpdatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Put<Company>(this);
        }

        public void Post()
        {
            this.CreatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Post<Company>(this);
        }

        public void Delete()
        {
            Dic.Get<IpOmmesDataBL>().Delete<Company>(this);
        }

        public static void Put(Collection<Company> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Company>(collectionToPut);
        }

        public static void Post(Collection<Company> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Company>(collectionToPost);
        }

        public static void Delete(Collection<Company> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Company>(collectionToDelete);
        }
    }
}
