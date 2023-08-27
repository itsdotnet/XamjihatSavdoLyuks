using UchKardesh.Domain.Commons;
using UchKardesh.Domain.Enums;

namespace UchKardesh.Domain.Entities;

public class Session : Auditable
{
    public SessionStatus Status { get; set; }
    public decimal Amount { get; set; }
    public decimal Price { get; set; }

    public long ProductId { get; set; }
    public Product Product { get; set; }
}
