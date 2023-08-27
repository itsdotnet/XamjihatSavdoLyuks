using UchKardesh.Domain.Commons;

namespace UchKardesh.Domain.Entities;

public class Attachment : Auditable
{
    public string Name { get; set; }
    public string Path { get; set; }
}
