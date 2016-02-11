using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class ArticleToSize : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public double Price
        {
            get;
            set;
        }

        public Size Size
        {
            get;
            set;
        }

        public override string ToString()
        {
            if (Size != null)
            {
                return Size.Name + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }

        public static Collection<ArticleToSize> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<ArticleToSize>();
        }

        public static Collection<ArticleToSize> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<ArticleToSize>(filter);
        }

        public static ArticleToSize Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<ArticleToSize>(objectId);
        }

        public void Put()
        {
            this.UpdatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Put<ArticleToSize>(this);
        }

        public void Post()
        {
            this.CreatedAt = DateTime.Now;

            Dic.Get<IpOmmesDataBL>().Post<ArticleToSize>(this);
        }

        public void Delete()
        {
            Dic.Get<IpOmmesDataBL>().Delete<ArticleToSize>(this);
        }

        public static void Put(Collection<ArticleToSize> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<ArticleToSize>(collectionToPut);
        }

        public static void Post(Collection<ArticleToSize> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<ArticleToSize>(collectionToPost);
        }

        public static void Delete(Collection<ArticleToSize> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<ArticleToSize>(collectionToDelete);
        }
    }
}
