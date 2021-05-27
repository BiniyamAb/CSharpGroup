
using CSharpGroup.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpGroup.Services
{
    public class CRUDService<T> where T : ModelInterface
    {
        private readonly IMongoCollection<T> _items;

        public CRUDService(ICSharpGroupDatabaseSettings settings, MongoClientService mongoClientService)
        {
            Type listType = typeof(T);
            if (listType == typeof(User))
            {
                _items = mongoClientService.db.GetCollection<T>(settings.UsersCollectionName);
            }
            else if(listType == typeof(Provider))
            {
                _items = mongoClientService.db.GetCollection<T>(settings.ProvidersCollectionName);
            }
            else if(listType == typeof(Category))
            {
                _items = mongoClientService.db.GetCollection<T>(settings.CategoriesCollectionName);
            }
            else if(listType == typeof(Order))
            {
                _items = mongoClientService.db.GetCollection<T>(settings.OrdersCollectionName);
            }
            else if(listType == typeof(Review))
            {
                _items = mongoClientService.db.GetCollection<T>(settings.ReviewsCollectionName);
            }
            
            
        }

        public List<T> Get() => _items.Find(item => true).ToList();

        public T Get(string id) =>
            _items.Find(item => item.Id == id).FirstOrDefault();

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
