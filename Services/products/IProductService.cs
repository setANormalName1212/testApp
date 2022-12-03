using Product.Models;

namespace Product.Services.Product;

public interface IProductService {
  void CreateProduct(Product product);

  Product getProduct(Guid id);
}