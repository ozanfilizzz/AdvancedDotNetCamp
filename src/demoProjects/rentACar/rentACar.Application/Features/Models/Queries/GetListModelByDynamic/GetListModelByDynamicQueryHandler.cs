using AutoMapper;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using rentACar.Application.Services.Repositories;
using rentACar.Domain.Entities;

namespace rentACar.Application.Features.Models.Queries.GetListModelByDynamic
{
    public class GetListModelByDynamicQueryHandler : IRequestHandler<GetListModelByDynamicQueryRequest, GetListModelByDynamicQueryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IModelRepository _modelRepository;

        public GetListModelByDynamicQueryHandler(IMapper mapper, IModelRepository modelRepository)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }

        public async Task<GetListModelByDynamicQueryResponse> Handle(GetListModelByDynamicQueryRequest request, CancellationToken cancellationToken)
        {

            IPaginate<Model> models = await _modelRepository.GetListByDynamicAsync(request.Dynamic,
                include:
                m => m.Include(b => b.Brand),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize
                );

            GetListModelByDynamicQueryResponse getListModelByDynamicQueryResponse = _mapper.Map<GetListModelByDynamicQueryResponse>(models);

            return getListModelByDynamicQueryResponse;
        }
    }
}
