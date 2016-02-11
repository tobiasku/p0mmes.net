using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Category : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }

        public static Collection<Category> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Category>();
        }

        public static Collection<Category> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Category>(filter);
        }

        public static Category Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Category>(objectId);
        }

        public void Put()
        {
            this.UpdatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Put<Category>(this);
        }

        public void Post()
        {
            this.CreatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Post<Category>(this);
        }

        public void Delete()
        {
            Dic.Get<IpOmmesDataBL>().Delete<Category>(this);
        }

        public static void Put(Collection<Category> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Category>(collectionToPut);
        }

        public static void Post(Collection<Category> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Category>(collectionToPost);
        }

        public static void Delete(Collection<Category> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Category>(collectionToDelete);
        }
    }
}
