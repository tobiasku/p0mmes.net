using pOmmes.Common;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using Parse;

namespace pOmmes.Data
{
    public class pOmmesDataDLParse : IpOmmesDataDL, IDisposable
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------


        //--------------------------------------------------------------------------
        //-- Methods
        //--------------------------------------------------------------------------
        public pOmmesDataDLParse()
        {
            ParseClient.Initialize("gcB3bvLRmFS2uRur2UZKrAvvycyFA59lyrQ7VqZW", "5dXJZXLGYMWs9lv1ZkkdEQZhm8lI42Bt9IjgUyO7");
        }

        #region Get
        public Collection<T> Get<T>() where T : Base
        {
            return GetObjects<T>(null).Result;
        }

        public Collection<T> Get<T>(Dictionary<string, object> filter) where T : Base
        {
            return GetObjects<T>(filter).Result;
        }

        private async Task<Collection<T>> GetObjects<T>(Dictionary<string, object> filters) where T : Base
        {
            Type t = typeof(T);

            var query = ParseObject.GetQuery(t.Name);

            if (filters != null)
            {
                foreach (KeyValuePair<String, object> filter in filters)
                {

                    query = query.WhereEqualTo(filter.Key, filter.Value);
                }
            }

            IEnumerable<ParseObject> results = await query.FindAsync();


            Collection<T> resultCollection = new Collection<T>();

            foreach (ParseObject parseObject in results)
            {
                var result = (T)ParseConverter.ConvertParseToObject(parseObject, t);
                resultCollection.Add(result);
            }

            return resultCollection;
        }
        #endregion

        #region Find
        public T Find<T>(string objectId) where T : Base
        {
            if (!string.IsNullOrEmpty(objectId))
            {
                return FindObject<T>(objectId).Result;
            }
            else
            {
                return null;
            }
        }

        private async Task<T> FindObject<T>(string objectId) where T : Base
        {
            Type t = typeof(T);

            var query = ParseObject.GetQuery(t.Name);

            ParseObject result = await query.GetAsync(objectId);


            Collection<T> resultCollection = new Collection<T>();

            var resultObject = (T)ParseConverter.ConvertParseToObject(result, t);
            return resultObject;
        }
        #endregion

        #region Put
        public async void Put<T>(Collection<T> collectionToPut) where T : Base
        {
            foreach (T objectToPut in collectionToPut)
            {
                ParseObject parseObject = ParseConverter.ConvertObjectToParse(objectToPut);
                await parseObject.SaveAsync();
            }
        }
        #endregion

        #region Post
        public async void Post<T>(Collection<T> collectionToPost) where T : Base
        {
            foreach (T objectToPost in collectionToPost)
            {
                //List<PropertyInfo> props = GetPropertyInfoByType(typeof(T)).Where(x => x.PropertyType.BaseType == typeof(Base)).ToList<PropertyInfo>();
                //foreach (PropertyInfo prop in props)
                //{
                //    Base baseItem = (Base)prop.GetValue(value);
                //    if (baseItem != null)
                //    {
                //        if (baseItem._id == null)
                //        {
                //            baseItem._id = ObjectId.GenerateNewId(DateTime.Now).ToString();

                //            Post(new Collection<Base>() { prop.GetValue(value) as Base });
                //        }
                //    }
                //}

                //List<PropertyInfo> props1 = GetPropertyInfoByType(typeof(T)).Where(x => x.PropertyType == typeof(Collection<ArticleToSize>)).ToList<PropertyInfo>();
                //foreach (PropertyInfo prop in props1)
                //{
                //    Collection<ArticleToSize> articles = prop.GetValue(value) as Collection<ArticleToSize>;

                //    Post<ArticleToSize>(articles);
                //}

                //List<PropertyInfo> props2 = GetPropertyInfoByType(typeof(T)).Where(x => x.PropertyType == typeof(Collection<ArticleToOption>)).ToList<PropertyInfo>();
                //foreach (PropertyInfo prop in props2)
                //{
                //    Collection<ArticleToOption> options = prop.GetValue(value) as Collection<ArticleToOption>;

                //    Post<ArticleToOption>(options);
                //}

                //List<PropertyInfo> props3 = GetPropertyInfoByType(typeof(T)).Where(x => x.PropertyType == typeof(Collection<Vote>)).ToList<PropertyInfo>();
                //foreach (PropertyInfo prop in props3)
                //{
                //    Collection<Vote> votes = prop.GetValue(value) as Collection<Vote>;

                //    Post<Vote>(votes);
                //}

                ParseObject parseObject = ParseConverter.ConvertObjectToParse(objectToPost);
                await parseObject.SaveAsync();
            }
        }
        #endregion

        #region Delete
        public async void Delete<T>(Collection<T> collectionToDelete) where T : Base
        {
            foreach (T objectToDelete in collectionToDelete)
            {
                ParseObject parseObject = ParseConverter.ConvertObjectToParse(objectToDelete);
                await parseObject.DeleteAsync();
            }
        }

        //public async void DeleteAll<T>() where T : Base
        //{
        //    await _database.DropCollectionAsync(typeof(T).Name);
        //}
        #endregion

        #region Helper
        private static List<PropertyInfo> GetPropertyInfoByType(Type type)
        {
            List<PropertyInfo> props = new List<PropertyInfo>();
            if (type != null)
            {
                if (type.BaseType != null)
                {
                    props = type.BaseType.GetProperties().ToList<PropertyInfo>();
                }
                props.AddRange(type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            }
            return props;
        }
        #endregion

        public void Dispose()
        {
        }
    }
}
