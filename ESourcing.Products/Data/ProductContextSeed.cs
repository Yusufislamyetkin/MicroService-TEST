using ESourcing.Products.Entites;
using MongoDB.Driver;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            {
                if (existProduct)
                {
                    productCollection.InsertManyAsync(GetConfigureProducts());
                }
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
           {
               new Product()
               {
                         Name="Iphone x",
                          Description = " 0",
                           ImageFile="0",
                            Summary = "0",
                             Price = 15,
                              Category = "Phone"



               }
           };
        }
    }
}
