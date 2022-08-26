using AutoMapper;
using rentACar.Application.Features.Brands.Commands.CreateBrands;
using rentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateBrandCommandMaps();
        }




        protected virtual void CreateBrandCommandMaps()
        {
            CreateMap<Brand, CreateBrandCommandRequest>().ReverseMap();
            CreateMap<Brand, CreatedBrandCommandResponse>().ReverseMap();
        }
    }
}
