using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Size : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }

        public static Collection<Size> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Size>();
        }

        public static Collection<Size> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Size>(filter);
        }

        public static Size Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Size>(objectId);
        }

        public static void Put(Collection<Size> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Size>(collectionToPut);
        }

        public static void Post(Collection<Size> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Size>(collectionToPost);
        }

        public static void Delete(Collection<Size> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Size>(collectionToDelete);
        }
    }
}
