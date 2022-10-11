using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
