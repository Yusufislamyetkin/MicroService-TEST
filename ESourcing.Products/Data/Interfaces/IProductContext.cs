using ESourcing.Products.Entites;
using MongoDB.Driver;

namespace ESourcing.Products.Data.Interfaces
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
