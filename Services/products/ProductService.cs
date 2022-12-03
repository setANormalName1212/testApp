using Product.Models;

namespace Product.Services.Product;

public class ProductService : IProductService {
  private static readonly Dictionary<Guid, Product> _products = new();
  
  public void CreateProduct(Product product)
  {
    _product.Add(product.Id, product)
  }

  public Product getProduct(Guid id) {
    return _product[id];
  }

  public void DeleteProduct(Guid id) {
    _product.Remove(id);
  }

  public void UpdateProduct(Product product) {
    _product[product.Id] = product;
  }
}