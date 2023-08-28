namespace UchKardesh.Service.DTOs.Users;

public class UserCreationDto
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Password { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long? UpdatedFrom { get; set; }
}