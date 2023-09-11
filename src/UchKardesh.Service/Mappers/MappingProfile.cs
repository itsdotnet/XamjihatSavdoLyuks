using AutoMapper;
using UchKardesh.Domain.Entities;
using UchKardesh.Service.DTOs.Attachments;
using UchKardesh.Service.DTOs.Categories;
using UchKardesh.Service.DTOs.Products;
using UchKardesh.Service.DTOs.Sessions;
using UchKardesh.Service.DTOs.Users;

namespace UchKardesh.Service.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region User

        CreateMap<UserCreationDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<User, UserResultDto>().ReverseMap();
        CreateMap<UserUpdateDto, UserResultDto>().ReverseMap();

        #endregion

        #region Product

        CreateMap<ProductCreationDto, Product>().ReverseMap();
        CreateMap<ProductUpdateDto, Product>().ReverseMap();
        CreateMap<Product, ProductResultDto>().ReverseMap();
        CreateMap<ProductResultDto, ProductUpdateDto>().ReverseMap();

        #endregion

        #region Category

        CreateMap<CategoryCreationDto, Category>().ReverseMap();
        CreateMap<CategoryUpdateDto, Category>().ReverseMap();
        CreateMap<Category, CategoryResultDto>().ReverseMap();
        CreateMap<CategoryResultDto, CategoryUpdateDto>().ReverseMap();

        #endregion

        #region Session
        
        CreateMap<SessionCreationDto, Session>().ReverseMap();
        CreateMap<SessionUpdateDto, Session>().ReverseMap();
        CreateMap<Session, SessionResultDto>().ReverseMap();
        CreateMap<SessionResultDto, SessionUpdateDto>().ReverseMap();

        #endregion

        #region Attachment

        CreateMap<Attachment, AttachmentResultDto>().ReverseMap();

        #endregion
    }
}
