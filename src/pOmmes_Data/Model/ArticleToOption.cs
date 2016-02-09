using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class ArticleToOption : Base
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

        public Option Option
        {
            get;
            set;
        }

        public override string ToString()
        {
            if (Option != null)
            {
                return Option.Name + " (+ " + Price.ToString("0.00") + " €)";
            }
            else
            {
                return base.ToString();
            }
        }

        public static Collection<ArticleToOption> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<ArticleToOption>();
        }

        public static Collection<ArticleToOption> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<ArticleToOption>(filter);
        }

        public static ArticleToOption Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<ArticleToOption>(objectId);
        }

        public static void Put(Collection<ArticleToOption> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<ArticleToOption>(collectionToPut);
        }

        public static void Post(Collection<ArticleToOption> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<ArticleToOption>(collectionToPost);
        }

        public static void Delete(Collection<ArticleToOption> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<ArticleToOption>(collectionToDelete);
        }
    }
}
