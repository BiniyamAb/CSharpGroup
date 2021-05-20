using CSharpGroup.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Services
{
    public class CRUDService<T> where T : ModelInterface
    {
        private readonly IMongoCollection<T> _items;

        public CRUDService(string CollectionName, MongoClientService mongoClientService)
        {
            _items = mongoClientService.db.GetCollection<T>(CollectionName);
        }

        public List<T> Get() =>
            _items.Find(item => true).ToList();

        public T Get(string id) =>
            _items.Find<T>(item => item.Id == id).FirstOrDefault();

        public T Create(T item)
        {
            _items.InsertOne(item);
            return item;
        }

        public void Update(string id, T itemIn) =>
            _items.ReplaceOne(item => item.Id == id, itemIn);

        public void Remove(T itemIn) =>
            _items.DeleteOne(item => item.Id == itemIn.Id);

        public void Remove(string id) =>
            _items.DeleteOne(item => item.Id == id);
    }
}
