using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Order : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public User User
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public Collection<OrderPosition> OrderPositions
        {
            get;
            set;
        }

        public static Collection<Order> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Order>();
        }

        public static Collection<Order> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Order>(filter);
        }

        public static Order Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Order>(objectId);
        }

        public static void Put(Collection<Order> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Order>(collectionToPut);
        }

        public static void Post(Collection<Order> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Order>(collectionToPost);
        }

        public static void Delete(Collection<Order> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Order>(collectionToDelete);
        }
    }
}
