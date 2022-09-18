using AutoMapper;
using Core.Persistence.Paging;
using rentACar.Application.Features.Brands.Commands.CreateBrands;
using rentACar.Application.Features.Brands.Dtos;
using rentACar.Application.Features.Brands.Queries.GetListBrand;
using rentACar.Domain.Entities;

namespace rentACar.Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateBrandCommandMaps();
            GetListBrandQueryMaps();
        }


        protected virtual void CreateBrandCommandMaps()
        {
            CreateMap<Brand, CreateBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, CreatedBrandCommandResponse>().ReverseMap();
        }

        protected virtual void GetListBrandQueryMaps()
        {
            CreateMap<IPaginate<Brand>, GetListBrandQueryResponse>().ReverseMap();
            CreateMap<Brand, BrandListDto>().ReverseMap();
        }
    }
}
