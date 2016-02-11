using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class OrderPosition : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public Article Article
        {
            get;
            set;
        }

        public ArticleToSize Size
        {
            get;
            set;
        }

        public Collection<ArticleToOption> Options
        {
            get;
            set;
        }

        public string ExtraInformation
        {
            get;
            set;
        }

        public static Collection<OrderPosition> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<OrderPosition>();
        }

        public static Collection<OrderPosition> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<OrderPosition>(filter);
        }

        public static OrderPosition Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<OrderPosition>(objectId);
        }

        public static void Put(Collection<OrderPosition> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<OrderPosition>(collectionToPut);
        }

        public static void Post(Collection<OrderPosition> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<OrderPosition>(collectionToPost);
        }

        public static void Delete(Collection<OrderPosition> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<OrderPosition>(collectionToDelete);
        }
    }
}
