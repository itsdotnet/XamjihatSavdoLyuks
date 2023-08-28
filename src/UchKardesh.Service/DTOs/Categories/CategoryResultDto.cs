using UchKardesh.Service.DTOs.Products;

namespace UchKardesh.Service.DTOs.Categories;

public class CategoryResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<ProductResultDto> Products { get; set; }
    public long? UpdatedFrom { get; set; }
}