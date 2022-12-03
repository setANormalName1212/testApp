namespace Product.Contracts.Product;

public record UpdateProductReq(
  string Title,  
  int Price,
  string Description,
  List<string> Tags,
  string Category,
  string Subcategory
);