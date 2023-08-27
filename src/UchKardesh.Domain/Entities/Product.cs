using UchKardesh.Domain.Commons;
using UchKardesh.Domain.Enums;

namespace UchKardesh.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal BoughtPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public decimal Amount { get; set; }
    public ProductType Type { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; }

    public long? ImageId { get; set; }
    public Attachment Attachment { get; set; }
}
