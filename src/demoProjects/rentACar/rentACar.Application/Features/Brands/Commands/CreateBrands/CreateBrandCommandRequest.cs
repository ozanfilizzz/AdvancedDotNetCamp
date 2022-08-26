using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar.Application.Features.Brands.Commands.CreateBrands
{
    public class CreateBrandCommandRequest : IRequest<CreatedBrandCommandResponse>
    {
        public string Name { get; set; }
    }
}
