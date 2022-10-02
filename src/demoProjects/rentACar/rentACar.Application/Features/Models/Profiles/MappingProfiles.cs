using Core.Persistence.Paging;
using rentACar.Application.Features.Models.Dtos;
using rentACar.Domain.Entities;
using AutoMapper;
using rentACar.Application.Features.Models.Queries.GetListModel;
using rentACar.Application.Features.Models.Queries.GetListModelByDynamic;

namespace rentACar.Application.Features.Models.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            GetListModelQueryMaps();
            GetListModelByDynamicQueryMaps();

        }


        protected virtual void GetListModelQueryMaps()
        {
            CreateMap<IPaginate<Model>, GetListModelQueryResponse>().ReverseMap();
            CreateMap<Model, ModelListDto>().ForMember(x=>x.BrandName, opt=>opt.MapFrom(x=>x.Brand.Name)).ReverseMap();
        }

        protected virtual void GetListModelByDynamicQueryMaps()
        {
            CreateMap<IPaginate<Model>, GetListModelByDynamicQueryResponse>().ReverseMap();
            CreateMap<Model, ModelListDto>().ForMember(x => x.BrandName, opt => opt.MapFrom(x => x.Brand.Name)).ReverseMap();
        }
    }
}
