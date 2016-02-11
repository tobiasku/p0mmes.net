using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Vote : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public User User
        {
            set;
            get;
        }

        public Restaurant Restaurant
        {
            set;
            get;
        }

        public static Collection<Vote> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Vote>();
        }

        public static Collection<Vote> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Vote>(filter);
        }

        public static Vote Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Vote>(objectId);
        }

        public static void Put(Collection<Vote> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Vote>(collectionToPut);
        }

        public static void Post(Collection<Vote> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Vote>(collectionToPost);
        }

        public static void Delete(Collection<Vote> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Vote>(collectionToDelete);
        }
    }
}