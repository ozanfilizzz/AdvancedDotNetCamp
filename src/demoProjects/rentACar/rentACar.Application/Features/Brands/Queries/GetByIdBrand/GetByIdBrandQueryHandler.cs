using AutoMapper;
using MediatR;
using rentACar.Application.Features.Brands.Rules;
using rentACar.Application.Services.Repositories;
using rentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Brands.Queries.GetByIdBrand
{
    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQueryRequest, GetByIdBrandQueryResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;

        public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<GetByIdBrandQueryResponse> Handle(GetByIdBrandQueryRequest request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(b => b.Id == request.Id);
            _brandBusinessRules.BrandShouldExistWhenRequested(brand);


            GetByIdBrandQueryResponse brandGetByIdResponse = _mapper.Map<GetByIdBrandQueryResponse>(brand);
            return brandGetByIdResponse;
        }
    }
}
