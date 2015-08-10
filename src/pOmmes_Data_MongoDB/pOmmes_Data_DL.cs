using pOmmes.Common;
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
            _client = new MongoClient("mongodb://localhost:27017");
            _database = _client.GetDatabase("pOmmes");
        }

        private IMongoCollection<BsonDocument> GetCollection<T>()
        {
            return _database.GetCollection<BsonDocument>(typeof(T).Name);
        }

        public Collection<T> Get<T>() where T : Base
        {
            return GetObjects<T>().Result;
        }

        public Collection<T> Get<T>(Dictionary<string, object> filter) where T : Base
        {
            var builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filterDefinition = null;

            //foreach (KeyValuePair<string, object> value in filter)
            //{
            //    if (filterDefinition != null)
            //    {
            //        filter = filter & builder.Eq(value.Key, value.Value);
            //            }
            //    else
            //    {

            //    }
            //}

            return null;
        }

        private async Task<Collection<T>> GetObjects<T>() where T : Base
        {
            Collection<T> result = new Collection<T>();

            var collection = GetCollection<T>();

            var filter = new BsonDocument();
            var docs = await collection.Find(filter).ToListAsync();

            foreach (var doc in docs)
            {
                string json = doc.ToJson();
                result.Add((T)JsonConvert.DeserializeObject(json, typeof(T), new JsonConverter[] { new CustomJsonSerializer() }));
            }

            return result;
        }

        public T Find<T>(string objectId) where T : Base
        {
            return FindObject<T>(objectId).Result;
        }

        private async Task<T> FindObject<T>(string objectId) where T : Base
        {
            T result = Activator.CreateInstance<T>();

            var collection = GetCollection<T>();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", objectId);

            var document = await collection.Find(filter).FirstAsync();

            string json = document.ToJson();
            return (T)JsonConvert.DeserializeObject(json, typeof(T), new JsonConverter[] { new CustomJsonSerializer() });
        }

        public void Put<T>(Collection<T> collectionToPut) where T : Base
        {
        }

        public async void Post<T>(Collection<T> collectionToPost) where T : Base
        {
            var collection = GetCollection<T>();
            Collection<BsonDocument> documents = new Collection<BsonDocument>();

            foreach (T value in collectionToPost)
            {
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

        public void Delete<T>(Collection<T> collectionToDelete) where T : Base
        {
        }

        public async void DeleteAll<T>(Collection<T> collectionToDelete) where T : Base
        {
            var collection = GetCollection<T>();
            var filter = new BsonDocument();
            var result = await collection.DeleteManyAsync(filter);
        }

        public async void DeleteAll<T>() where T : Base
        {
            await _database.DropCollectionAsync(typeof(T).Name);
        }

        public void Dispose()
        {
        }
    }
}
