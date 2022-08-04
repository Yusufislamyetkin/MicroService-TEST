using MongoDB.Bson.Serialization.Attributes;

namespace ESourcing.Products.Dtos
{
    public class AddProductDto
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public string Category { get; set; }

        public Decimal Price { get; set; }
    }
}
