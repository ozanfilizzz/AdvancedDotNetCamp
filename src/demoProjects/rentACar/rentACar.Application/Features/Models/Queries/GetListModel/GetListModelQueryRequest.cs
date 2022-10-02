using Core.Application.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Models.Queries.GetListModel
{
    public class GetListModelQueryRequest : IRequest<GetListModelQueryResponse>
    {
        public PageRequest PageRequest { get; set; }
    }
}
