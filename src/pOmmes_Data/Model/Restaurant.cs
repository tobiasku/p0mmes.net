using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
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

        public static Collection<Restaurant> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Restaurant>();
        }

        public static Collection<Restaurant> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Restaurant>(filter);
        }

        public static Restaurant Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Restaurant>(objectId);
        }

        public void Put()
        {
            this.UpdatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Put<Restaurant>(this);
        }

        public void Post()
        {
            this.CreatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Post<Restaurant>(this);
        }

        public void Delete()
        {
            Dic.Get<IpOmmesDataBL>().Delete<Restaurant>(this);
        }

        public static void Put(Collection<Restaurant> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Restaurant>(collectionToPut);
        }

        public static void Post(Collection<Restaurant> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Restaurant>(collectionToPost);
        }

        public static void Delete(Collection<Restaurant> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Restaurant>(collectionToDelete);
        }
    }
}
