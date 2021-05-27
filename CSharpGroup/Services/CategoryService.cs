using CSharpGroup.Models;
using CSharpGroup.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Services
{
    public class CategoryService
    {
        private readonly IMongoCollection<Category> _categories;

        public CategoryService(ICSharpGroupDatabaseSettings settings, MongoClientService mongoClientService)
        {
            _categories = mongoClientService.db.GetCollection<Category>(settings.CategoriesCollectionName);
        }

        public List<Category> Get() =>
            _categories.Find(Category => true).ToList();

        public Category Get(string id) =>
            _categories.Find<Category>(Category => Category.Id == id).FirstOrDefault();

        public Category Create(Category Category)
        {
            _categories.InsertOne(Category);
            return Category;
        }

        public void Update(string id, Category categoryIn) =>
            _categories.ReplaceOne(Category => Category.Id == id, categoryIn);

        public void Remove(Category categoryIn) =>
            _categories.DeleteOne(Category => Category.Id == categoryIn.Id);

        public void Remove(string id) =>
            _categories.DeleteOne(Category => Category.Id == id);
    }
}
