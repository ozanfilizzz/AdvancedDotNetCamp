using AutoMapper;
using Core.Persistence.Paging;
using MediatR;
using rentACar.Application.Services.Repositories;
using rentACar.Domain.Entities;

namespace rentACar.Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQueryRequest, GetListBrandQueryResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        
        public async Task<GetListBrandQueryResponse> Handle(GetListBrandQueryRequest request, CancellationToken cancellationToken)
        {
            IPaginate<Brand> brands = await _brandRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

            GetListBrandQueryResponse mappedBrandListResponse = _mapper.Map<GetListBrandQueryResponse>(brands);

            return mappedBrandListResponse;
        }
    }
}
