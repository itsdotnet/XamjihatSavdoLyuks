using UchKardesh.Service.DTOs.Users;

namespace UchKardesh.Service.Interfaces;

public interface IUserService
{
    Task<bool> DeleteAsync(long id);
    Task<UserResultDto> GetByIdAsync(long id);
    Task<IEnumerable<UserResultDto>> GetAllAsync();
    Task<UserResultDto> ModifyAsync(UserUpdateDto dto);
    Task<UserResultDto> CreateAsync(UserCreationDto dto);
    Task<IEnumerable<UserResultDto>> GetByName(string name);
    Task<bool> CheckUserAsync(string firstname, string password);
    Task<UserResultDto> ModifyPasswordAsync(long id, string oldPass, string newPass);
}