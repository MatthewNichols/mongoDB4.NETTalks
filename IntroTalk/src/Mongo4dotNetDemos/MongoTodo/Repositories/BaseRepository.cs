using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoTodo.Models;

namespace MongoTodo.Repositories
{
    public abstract class BaseRepository<T> where T: DomainBase
    {
        private IMongoDatabase _mongoDatabase;

        protected BaseRepository(string connectionString)
        {
            var mongoUrl = MongoUrl.Create(connectionString);
            var mongoClient = new MongoClient(mongoUrl);
            _mongoDatabase = mongoClient.GetDatabase(mongoUrl.DatabaseName);
        }

        public IMongoCollection<T> GetCollection()
        {
            return _mongoDatabase.GetCollection<T>(CollectionName);
        }

        protected abstract string CollectionName { get; } 

        public async virtual Task<T> Insert(T document)
        {
            await GetCollection().InsertOneAsync(document);
            return document;
        }

        /// <summary>
        /// If you can live with "Last Updater wins" then ReplaceOne is a nice simple strategy.
        /// </summary>
        public async virtual Task Update(ObjectId id, T document)
        {
            await GetCollection().ReplaceOneAsync(x => x.Id == document.Id, document);
        }

        public async virtual Task Delete(ObjectId id)
        {
            await GetCollection().DeleteOneAsync(arg => arg.Id == id);
        }

        public async virtual Task<IList<T>> GetAll(int start = 0, int pageSize = 10)
        {
            return await GetCollection()
                .Find(new BsonDocument())
                .Skip(start)
                .Limit(pageSize)
                .ToListAsync();
        }

        public async virtual Task<T> GetById(ObjectId id)
        {
            return await GetCollection()
                .Find(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
