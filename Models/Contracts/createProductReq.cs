namespace Product.Contracts.Product;

public record CreateProductReq(
  string Title,
  int Price,
  string Description,
  List<string> Tags,
  string Category,
  string Subcategory
);