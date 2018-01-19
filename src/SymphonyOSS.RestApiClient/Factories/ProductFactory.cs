namespace SymphonyOSS.RestApiClient.Factories
{
    using Product = Entities.Product;

    public class ProductFactory
    {
        public static Product Create(Generated.OpenApi.PodApi.Product product)
        {
            return new Product(product.AppId, product.Name, product.Sku, product.Subscribed, product.Type);
        }
    }
}
