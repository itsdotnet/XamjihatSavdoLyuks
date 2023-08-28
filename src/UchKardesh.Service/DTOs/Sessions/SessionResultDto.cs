using UchKardesh.Domain.Enums;
using UchKardesh.Service.DTOs.Products;

namespace UchKardesh.Service.DTOs.Sessions;

public class SessionResultDto
{
    public long Id { get; set; }
    public SessionStatus Status { get; set; }
    public decimal Amount { get; set; }
    public decimal Price { get; set; }
    public ProductResultDto Product { get; set; }
    public long? UpdatedFrom { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
