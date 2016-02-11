using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Option : Base
    {        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }
        public static Collection<Option> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Option>();
        }

        public static Collection<Option> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Option>(filter);
        }

        public static Option Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Option>(objectId);
        }

        public static void Put(Collection<Option> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Option>(collectionToPut);
        }

        public static void Post(Collection<Option> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Option>(collectionToPost);
        }

        public static void Delete(Collection<Option> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Option>(collectionToDelete);
        }
    }
}
