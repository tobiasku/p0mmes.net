using pOmmes.Common.Dic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace pOmmes.Data
{
    public class Article : Base
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        public string Name
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }

        public Restaurant Restaurant
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public Category Category
        {
            get;
            set;
        }

        public Collection<ArticleToSize> Sizes
        {
            get;
            set;
        }

        public Collection<ArticleToOption> Options
        {
            get;
            set;
        }

        public Article()
        {
            Sizes = new Collection<ArticleToSize>();
            Options = new Collection<ArticleToOption>();
        }

        public static Collection<Article> Get()
        {
            return Dic.Get<IpOmmesDataBL>().Get<Article>();
        }

        public static Collection<Article> Get(Dictionary<string, object> filter)
        {
            return Dic.Get<IpOmmesDataBL>().Get<Article>(filter);
        }

        public static Article Find(string objectId)
        {
            return Dic.Get<IpOmmesDataBL>().Find<Article>(objectId);
        }

        public static void Put(Collection<Article> collectionToPut)
        {
            foreach (var toPut in collectionToPut)
            {
                toPut.UpdatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Put<Article>(collectionToPut);
        }

        public static void Post(Collection<Article> collectionToPost)
        {
            foreach (var toPost in collectionToPost)
            {
                toPost.CreatedAt = DateTime.Now;
            }

            Dic.Get<IpOmmesDataBL>().Post<Article>(collectionToPost);
        }

        public static void Delete(Collection<Article> collectionToDelete)
        {
            Dic.Get<IpOmmesDataBL>().Delete<Article>(collectionToDelete);
        }
    }
}
