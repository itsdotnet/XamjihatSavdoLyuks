using UchKardesh.Domain.Enums;

namespace UchKardesh.Service.DTOs.Sessions;

public class SessionUpdateDto
{
    public long Id { get; set; }
    public SessionStatus Status { get; set; }
    public decimal Amount { get; set; }
    public decimal Price { get; set; }
    public long ProductId { get; set; }
}
