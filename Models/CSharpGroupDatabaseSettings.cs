using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class CSharpGroupDatabaseSettings : ICSharpGroupDatabaseSettings
    {
        public string UsersCollectionName { get; set; }
        public string ProvidersCollectionName { get; set; }
        public string CategoriesCollectionName { get; set; }
        public string OrdersCollectionName { get; set; }
        public string ReviewsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ICSharpGroupDatabaseSettings
    {
        string UsersCollectionName { get; set; }
        string ProvidersCollectionName { get; set; }
        string CategoriesCollectionName { get; set; }
        string OrdersCollectionName { get; set; }
        string ReviewsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}
