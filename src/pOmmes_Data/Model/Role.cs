using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Role : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }

        public static Collection<Role> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Role>();
        }

        public static Collection<Role> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Role>(filter);
        }

        public static Role Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Role>(objectId);
        }

        public void Put()
        {
            this.UpdatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Put<Role>(this);
        }

        public void Post()
        {
            this.CreatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Post<Role>(this);
        }

        public void Delete()
        {
            Dic.Get<IpOmmesDataBL>().Delete<Role>(this);
        } 

        public static void Put(Collection<Role> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Role>(collectionToPut);
        }

        public static void Post(Collection<Role> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Role>(collectionToPost);
        }

        public static void Delete(Collection<Role> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Role>(collectionToDelete);
        }
    }
}
