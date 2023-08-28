using UchKardesh.Domain.Enums;

namespace UchKardesh.Service.DTOs.Sessions;

public class SessionCreationDto
{
    public SessionStatus Status { get; set; }
    public decimal Amount { get; set; }
    public decimal Price { get; set; }
    public long ProductId { get; set; }
    public long? UpdatedFrom { get; set; }
}