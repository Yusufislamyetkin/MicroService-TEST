﻿
using ESourcing.Products.Data.Interfaces;
using ESourcing.Products.Entites;
using ESourcing.Products.Settings;
using MongoDB.Driver;

namespace ESourcing.Products.Data
{
    public class ProductContext : IProductContext
    {
        public ProductContext(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionStrings);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);
            ProductContextSeed.SeedData(Product);

        }

        public IMongoCollection<Product> Products { get; }
    }
}
