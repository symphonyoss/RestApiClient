
namespace SymphonyOSS.RestApiClient.Entities
{
    public class Product
    {

        /// <summary>App ID for the Product</summary>
        public string AppId { get; }

        /// <summary>Product Name</summary>
        public string Name { get; }

        /// <summary>Product SKU</summary>
        public string Sku { get; }

        /// <summary>indicate whether the product is subscribed or not</summary>
        public bool Subscribed { get; }

        /// <summary>Product Type (default or premium)</summary>
        public string Type { get; }

        public Product(string appId, string name, string sku, bool subscribed, string type)
        {
            AppId = appId;
            Name = name;
            Sku = sku;
            Subscribed = subscribed;
            Type = type;
        }
    }
}
