namespace Product.Contracts.Product;

public record ProductRes(
  Guid Id,
  string Title,
  int Price,
  string Description,
  List<string> Tags,
  string Category,
  string Subcategory
);