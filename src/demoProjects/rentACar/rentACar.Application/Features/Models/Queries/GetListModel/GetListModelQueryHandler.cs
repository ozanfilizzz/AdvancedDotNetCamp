using AutoMapper;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using rentACar.Application.Services.Repositories;
using rentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Models.Queries.GetListModel
{
    public class GetListModelQueryHandler : IRequestHandler<GetListModelQueryRequest, GetListModelQueryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IModelRepository _modelRepository;

        public GetListModelQueryHandler(IMapper mapper, IModelRepository modelRepository)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
        }

        public async Task<GetListModelQueryResponse> Handle(GetListModelQueryRequest request, CancellationToken cancellationToken)
        {

            IPaginate<Model> models = await _modelRepository.GetListAsync(include:
                m=>m.Include(b=>b.Brand),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize
                );

            GetListModelQueryResponse getListModelQueryResponse = _mapper.Map<GetListModelQueryResponse>(models);

            return getListModelQueryResponse;
        }
    }
}
