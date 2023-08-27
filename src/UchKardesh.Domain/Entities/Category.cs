using UchKardesh.Domain.Commons;

namespace UchKardesh.Domain.Entities;

public class Category : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
}
