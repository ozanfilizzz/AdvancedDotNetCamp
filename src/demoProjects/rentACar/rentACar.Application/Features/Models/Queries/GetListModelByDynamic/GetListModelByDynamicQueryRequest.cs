using Core.Application.Requests;
using Core.Persistence.Dynamic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Models.Queries.GetListModelByDynamic
{
    public class GetListModelByDynamicQueryRequest : IRequest<GetListModelByDynamicQueryResponse>
    {
        public Dynamic Dynamic { get; set; }
        public PageRequest PageRequest { get; set; }
    }
}
