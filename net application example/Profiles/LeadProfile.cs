using AutoMapper;
using Entities;
using Models;
using Repository;
using Services;
using System.Diagnostics.Contracts;

namespace Profiles
{
    public class LeadProfile: Profile
    {
        public LeadProfile()
        {
            /*CreateMap<CategoryModel, CategoryEntity>();
            CreateMap<CategoryEntity, CategoryModel>();
            CreateMap<LeadEntity, LeadModel>();
            CreateMap<LeadModel, LeadEntity>();
            CreateMap<OrderModel, OrderEntity>();
            CreateMap<OrderEntity, OrderModel>();
            CreateMap<List<OrderModel>, List<OrderEntity>>();
            CreateMap<List<OrderEntity>, List<OrderModel>>();
            CreateMap<ProductModel, ProductEntity>();
            CreateMap<ProductEntity, ProductModel>();
            CreateMap<List<ProductModel>, List<ProductEntity>>();
            CreateMap<List<ProductEntity>, List<ProductModel>>();
            CreateMap<PersonModel, PersonEntity>();
            CreateMap<PersonEntity, PersonModel>();*/

            CreateMap<LeadEntity, LeadModel>();
            CreateMap<LeadModel, LeadEntity>();

            // Add mappings for new models
            CreateMap<CategoryEntity, CategoryModel>();
            CreateMap<CategoryModel, CategoryEntity>();

            CreateMap<CompanyEntity, CompanyModel>();
            CreateMap<CompanyModel, CompanyEntity>();

            CreateMap<LegalEntity, LegalModel>()
                .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.Company))
                .ForMember(dest => dest.Lead, opt => opt.MapFrom(src => src.Lead));

            CreateMap<OrderEntity, OrderModel>()
                .ForMember(dest => dest.Lead, opt => opt.MapFrom(src => src.Lead))
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));

            CreateMap<PersonEntity, PersonModel>();
            CreateMap<PersonModel, PersonEntity>();

            CreateMap<ProductEntity, ProductModel>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId));

            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();
        }
    }
}