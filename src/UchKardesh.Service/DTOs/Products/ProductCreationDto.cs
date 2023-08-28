using UchKardesh.Domain.Enums;

namespace UchKardesh.Service.DTOs.Products;

public class ProductCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal BoughtPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public decimal Amount { get; set; }
    public ProductType Type { get; set; }
    public long CategoryId { get; set; }
    public long? ImageId { get; set; }
    public long? UpdatedFrom { get; set; }
}