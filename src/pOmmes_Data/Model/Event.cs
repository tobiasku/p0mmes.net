using pOmmes.Common;
using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Event : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public User UserCreated
        {
            get;
            set;
        }

        public Company Company
        {
            get;
            set;
        }

        public Restaurant Restaurant
        {
            get;
            set;
        }

        public DateTime DateToOrder
        {
            get;
            set;
        }

        public DateTime DateToVote
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public EventType EventType
        {
            get;
            set;
        }

        public EventState EventState
        {
            get;
            set;
        }

        public Collection<Vote> Votes
        {
            get;
            set;
        }

        public Collection<Order> Orders
        {
            get;
            set;
        }

        public Event()
        {
            Orders = new Collection<Order>();
            Votes = new Collection<Vote>();
        }

        public static Collection<Event> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Event>();
        }

        public static Collection<Event> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Event>(filter);
        }

        public static Event Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Event>(objectId);
        }

        public static void Put(Collection<Event> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Event>(collectionToPut);
        }

        public static void Post(Collection<Event> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Event>(collectionToPost);
        }

        public static void Delete(Collection<Event> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Event>(collectionToDelete);
        }
    }
}
