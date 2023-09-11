using AutoMapper;
using UchKardesh.DAL.IRepositories;
using UchKardesh.Domain.Entities;
using UchKardesh.Service.DTOs.Users;
using UchKardesh.Service.Exceptions;
using UchKardesh.Service.Helpers;
using UchKardesh.Service.Interfaces;

namespace UchKardesh.Service.Services;
#pragma warning disable CS1998

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UserService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> CheckUserAsync(string name, string password)
    {
        var user = await _unitOfWork.UserRepository.SelectAsync(x => x.Firstname == name);
        if (password.Verify(user.Password))
        {
            return true;
        }
        return false;
    }

    public async Task<UserResultDto> CreateAsync(UserCreationDto dto)
    {
        var newUser = _mapper.Map<User>(dto);
        newUser.Password = newUser.Password.Hash();
        await _unitOfWork.UserRepository.AddAsync(newUser);
        await _unitOfWork.SaveAsync();

        return _mapper.Map<UserResultDto>(newUser);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var user = await _unitOfWork.UserRepository.SelectAsync(q => q.Id == id);

        if (user is null)
            throw new NotFoundException("User not found");

        await _unitOfWork.UserRepository.DeleteAsync(x => x == user);
        return await _unitOfWork.SaveAsync();
    }

    public async Task<IEnumerable<UserResultDto>> GetAllAsync()
    {
        var users = _unitOfWork.UserRepository.SelectAll();

        return _mapper.Map<IEnumerable<UserResultDto>>(users);
    }

    public async Task<UserResultDto> GetByIdAsync(long id)
    {
        var user = await _unitOfWork.UserRepository.SelectAsync(q => q.Id == id);

        if (user is null)
            throw new NotFoundException("User not found");

        return _mapper.Map<UserResultDto>(user);
    }

    public async Task<IEnumerable<UserResultDto>> GetByName(string name)
    {
        var users = _unitOfWork.UserRepository.SelectAll(u =>
            u.Firstname.Contains(name) || u.Lastname.Contains(name));

        return _mapper.Map<IEnumerable<UserResultDto>>(users);
    }

    public async Task<UserResultDto> ModifyAsync(UserUpdateDto dto)
    {
        var exist = await _unitOfWork.UserRepository.SelectAsync(d => d.Id == dto.Id);

        if (exist is null)
            throw new NotFoundException("User not found");

        _mapper.Map(dto, exist);

        await _unitOfWork.UserRepository.UpdateAsync(exist);
        await _unitOfWork.SaveAsync();

        return _mapper.Map<UserResultDto>(exist);
    }

    public async Task<UserResultDto> ModifyPasswordAsync(long id, string oldPass, string newPass)
    {
        var exist = await _unitOfWork.UserRepository.SelectAsync(q => q.Id == id);

        if (exist is null)
            throw new NotFoundException("User not found");

        if (oldPass.Verify(exist.Password))
            throw new CustomException(403, "Passwor is invalid");

        exist.Password = newPass.Hash();
        await _unitOfWork.SaveAsync();

        return _mapper.Map<UserResultDto>(exist);
    }
}
