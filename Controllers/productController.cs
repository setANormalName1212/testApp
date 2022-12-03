using Microsoft.AspNetCore.Mvc;
using Product.Contracts.Product;
using Product.Service.Product;
using Product.Models;

namespace Products.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase
{
  private readonly IProductService _productService;

  public ProductController(IProductService productService) {
    _productService = product  Service
  }

  [HttpPost]
  public IActionResult CreateProduct(CreateProductReq request)
  {
    var product = new Product(
      Guid.newGuid(),
      request.Title,
      request.Description,
      request.Price,
      request.Tags,
      request.Category,
      request.Subcategory
    );

    _productService.CreateProduct(product);

    var response = new ProductRes(
      product.Id,
      product.Title,
      product.Price,
      product.Tags,
      product.Category,
      product.Subcategory
    )

    return CreatedAtAction(
      actionName: nameof(GetProduct),
      routeValues: new { id = product.Id },
      response
    );
  }

  [HttpGet("{id:guid}")]
  public IActionResult GetProduct(Guid id)
  {
    Product product = _productService.GetProduct(id)

    var response = new ProductRes(
      product.Id,
      product.Title,
      product.Price,
      product.Tags,
      product.Category,
      product.Subcategory
    )

    return Ok(response);
  }

  [HttpPut("{id:guid}")]
  public IActionResult UpdateProduct(Guid id, UpdateProductReq request)
  {
    var product = new Product(
      Guid.newGuid(),
      request.Title,
      request.Description,
      request.Price,
      request.Tags,
      request.Category,
      request.Subcategory
    );

    _productService.UpdateProduct(product);

    // TODO: return 201 if a new product was created

    return NoContent();
  }

  [HttpDelete("{id:guid")]
  public IActionResult DeleteProduct(Guid id)
  {
    _productService.DeleteProduct(id);

    return NoContent();
  }
}