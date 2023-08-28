using UchKardesh.Service.DTOs.Attachments;

namespace UchKardesh.Service.DTOs.Users;

public class UserUpdateDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public AttachmentResultDto Image { get; set; } 
    public DateTime DateOfBirth { get; set; }
    public long? UpdatedFrom { get; set; }
}