using Product.Services.Product;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddControllers();
  builder.Services.AddScoped<IProductService, ProductService>();
}
  

var app = builder.Build();
{  
  app.UseHttpsRedirection();  
  app.MapControllers();
  app.Run();
}
