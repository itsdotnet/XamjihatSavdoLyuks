using AutoMapper;
using UchKardesh.Domain.Entities;
using UchKardesh.Service.DTOs.Attachments;
using UchKardesh.Service.DTOs.Categories;
using UchKardesh.Service.DTOs.Products;
using UchKardesh.Service.DTOs.Users;

namespace UchKardesh.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        //user

        CreateMap<UserCreationDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<User, UserResultDto>().ReverseMap();
        CreateMap<UserUpdateDto, UserResultDto>().ReverseMap();

        //product

        CreateMap<ProductCreationDto, Product>().ReverseMap();
        CreateMap<ProductUpdateDto, Product>().ReverseMap();
        CreateMap<Product, ProductResultDto>().ReverseMap();
        CreateMap<ProductResultDto, ProductUpdateDto>().ReverseMap();

        //category

        CreateMap<CategoryCreationDto, Category>().ReverseMap();
        CreateMap<CategoryUpdateDto, Category>().ReverseMap();
        CreateMap<Category, CategoryResultDto>().ReverseMap();
        CreateMap<CategoryResultDto, CategoryUpdateDto>().ReverseMap();

        //attachment

        CreateMap<Attachment, AttachmentResultDto>().ReverseMap();
    }
}
