﻿using pOmmes.Common;
using pOmmes.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using System.Reflection;

namespace pOmmes.Data.Mongo
{
    public class pOmmesDataDL : IpOmmesDataDL, IDisposable
    {
        //--------------------------------------------------------------------------
        //-- Fields
        //--------------------------------------------------------------------------
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        //--------------------------------------------------------------------------
        //-- Methods
        //--------------------------------------------------------------------------
        public pOmmesDataDL()
        {
            //_client = new MongoClient("mongodb://root:Abl745er@ds055895.mongolab.com:55895");
            _client = new MongoClient("mongodb://localhost:27017");
            _database = _client.GetDatabase("pOmmes");
        }

        #region Get
        public Collection<T> Get<T>() where T : Base
        {
            return GetObjects<T>(new BsonDocument()).Result;
        }

        public Collection<T> Get<T>(Dictionary<string, object> filter) where T : Base
        {
            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = null;

            foreach (KeyValuePair<string, object> value in filter)
            {
                if (filterDefinition != null)
                {
                    filterDefinition = filterDefinition & builder.Eq(value.Key, value.Value);
                }
                else
                {
                    filterDefinition = builder.Eq(value.Key, value.Value);
                }
            }

            return GetObjects<T>(filterDefinition).Result;
        }

        private async Task<Collection<T>> GetObjects<T>(FilterDefinition<BsonDocument> filter) where T : Base
        {
            var collection = GetCollection(typeof(T));

            var docs = await collection.Find(filter).ToListAsync();

            Collection<T> resultCollection = new Collection<T>();
            foreach (var doc in docs)
            {
                string json = doc.ToJson();
                var result = (T)JsonConvert.DeserializeObject(json, typeof(T), new JsonConverter[] { new CustomJsonSerializer() });
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
            var collection = GetCollection(typeof(T));

            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = builder.Eq("_id", objectId);

            var document = await collection.Find(filterDefinition).FirstAsync();

            string json = document.ToJson();
            var result = (T)JsonConvert.DeserializeObject(json, typeof(T), new JsonConverter[] { new CustomJsonSerializer() });
            return result;
        }
        #endregion

        #region Put
        public async void Put<T>(Collection<T> collectionToPut) where T : Base
        {
            var collection = GetCollection(typeof(T));

            foreach (T value in collectionToPut)
            {
                var builder = Builders<BsonDocument>.Filter;
                FilterDefinition<BsonDocument> filterDefinition = builder.Eq("_id", value._id);

                string jsonString = JsonConvert.SerializeObject(value, new JsonConverter[] { new CustomJsonSerializer() });
                BsonDocument bsonDoc = BsonDocument.Parse(jsonString);

                await collection.ReplaceOneAsync(filterDefinition, bsonDoc);
            }
        }

        public async void Put<T>(T toPut) where T : Base
        {
            var collection = GetCollection(toPut.GetType());

            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = builder.Eq("_id", toPut._id);

            string jsonString = JsonConvert.SerializeObject(toPut, new JsonConverter[] { new CustomJsonSerializer() });
            BsonDocument bsonDoc = BsonDocument.Parse(jsonString);

            await collection.ReplaceOneAsync(filterDefinition, bsonDoc);
        }
        #endregion

        #region Post
        public async void Post<T>(Collection<T> collectionToPost) where T : Base
        {
            var collection = GetCollection(typeof(T));

            Collection<BsonDocument> documents = new Collection<BsonDocument>();

            foreach (T value in collectionToPost)
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

                value.CreatedAt = DateTime.Now;

                if (value._id == null)
                {
                    value._id = ObjectId.GenerateNewId(DateTime.Now).ToString();
                }

                string jsonString = JsonConvert.SerializeObject(value, new JsonConverter[] { new CustomJsonSerializer() });

                BsonDocument bsonDoc = BsonDocument.Parse(jsonString);

                documents.Add(bsonDoc);
            }

            await collection.InsertManyAsync(documents);
        }

        public async void Post<T>(T toPost) where T : Base
        {
            var collection = GetCollection(toPost.GetType());
            Collection<BsonDocument> documents = new Collection<BsonDocument>();

            toPost.CreatedAt = DateTime.Now;

            if (toPost._id == null)
            {
                toPost._id = ObjectId.GenerateNewId(DateTime.Now).ToString();
            }

            string jsonString = JsonConvert.SerializeObject(toPost, new JsonConverter[] { new CustomJsonSerializer() });

            BsonDocument bsonDoc = BsonDocument.Parse(jsonString);

            await collection.InsertOneAsync(bsonDoc);
        }
        #endregion

        #region Delete
        public async void Delete<T>(Collection<T> collectionToDelete) where T : Base
        {
            var collection = GetCollection(typeof(T));

            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = null;

            foreach (T objectToDelete in collectionToDelete)
            {
                if (filterDefinition != null)
                {
                    filterDefinition = filterDefinition & builder.Eq("_id", objectToDelete._id);
                }
                else
                {
                    filterDefinition = builder.Eq("_id", objectToDelete._id);
                }
            }

            var result = await collection.DeleteManyAsync(filterDefinition);
        }

        public async void Delete<T>(T toDelete) where T : Base
        {
            var collection = GetCollection(typeof(T));

            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = null;

            if (filterDefinition != null)
            {
                filterDefinition = filterDefinition & builder.Eq("_id", toDelete._id);
            }
            else
            {
                filterDefinition = builder.Eq("_id", toDelete._id);
            }

            var result = await collection.DeleteOneAsync(filterDefinition);
        }

        //public async void DeleteAll<T>() where T : Base
        //{
        //    await _database.DropCollectionAsync(typeof(T).Name);
        //}
        #endregion

        #region Helper
        private IMongoCollection<BsonDocument> GetCollection(Type type)
        {
            return _database.GetCollection<BsonDocument>(type.Name);
        }

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
