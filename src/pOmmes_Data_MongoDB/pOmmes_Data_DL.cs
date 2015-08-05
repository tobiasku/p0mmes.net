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
    public class pOmmesDataDL : IpOmmesDataDL
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
            _client = new MongoClient();
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

        private async Task<Collection<T>> GetObjects<T>() where T : Base
        {
            Collection<T> result = new Collection<T>();


            var collection = GetCollection<T>();
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        result.Add(BsonSerializer.Deserialize<T>(document));
                        count++;
                    }
                }
            }
            return result;
        }

        public Collection<T> Get<T>(string filterString) where T : Base
        {
            return null;
        }

        public T Find<T>(string objectId) where T : Base
        {
            return null;
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
            }

            //var bsonDoc = BsonArray.Parse(JsonConvert.SerializeObject(collectionToPost));

            //await collection.InsertManyAsync(bsonDoc);
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
    }
}
