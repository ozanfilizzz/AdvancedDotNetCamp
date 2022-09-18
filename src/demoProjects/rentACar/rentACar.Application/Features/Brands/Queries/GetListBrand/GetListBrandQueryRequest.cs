using Core.Application.Requests;
using MediatR;

namespace rentACar.Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQueryRequest : IRequest<GetListBrandQueryResponse>
    {
        public PageRequest PageRequest { get; set; }
    }
}
