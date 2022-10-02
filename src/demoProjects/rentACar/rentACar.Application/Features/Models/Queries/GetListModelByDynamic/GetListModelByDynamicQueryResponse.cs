using Core.Persistence.Paging;
using rentACar.Application.Features.Models.Dtos;

namespace rentACar.Application.Features.Models.Queries.GetListModelByDynamic
{
    public class GetListModelByDynamicQueryResponse : BasePageableModel
    {
        public IList<ModelListDto> Items { get; set; }
    }
}