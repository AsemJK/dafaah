namespace Dafaah.Products.Api.Services
{
    public record ProductDto(int? Id = 0, string? Name = "", decimal? Price = 0, decimal Quantity = 0);
}
