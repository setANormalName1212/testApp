namespace Product.Models;

public class Product {
  public Guid Id { get; }
  public string Title { get; }
  public string Price { get; }
  public string Description { get; }
  List<string> Tags { get; }
  string Category { get; }
  string Subcategory { get; }

  public Product(
    Guid id,
    string title,
    int price,
    string description,
    List<string> tags,
    string category,
    string subcategory
  )
  {
    // Enforce invariants
    Id = id;
    Title = title;
    Description = description;
    Tags = tags;
    Category = category;
    Subcategory = subcategory;
  }
}