using Core.Persistence.Paging;
using rentACar.Application.Features.Brands.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQueryResponse : BasePageableModel
    {
        public IList<BrandListDto> Items { get; set; }
    }
}
