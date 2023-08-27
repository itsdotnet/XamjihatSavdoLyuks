using UchKardesh.Domain.Commons;

namespace UchKardesh.Domain.Entities;

public class User : Auditable
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Password { get; set; }
    public DateTime DateOfBirth { get; set; }

    public long? ImageId { get; set; }
    public Attachment Image { get; set; }
}
