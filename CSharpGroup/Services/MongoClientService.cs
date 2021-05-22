using CSharpGroup.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Services
{

    public class MongoClientService
    {
        public IMongoDatabase db;
        public MongoClientService(ICSharpGroupDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            db = client.GetDatabase(settings.DatabaseName);
        }
    }
}
