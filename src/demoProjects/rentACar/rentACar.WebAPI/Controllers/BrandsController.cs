using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using rentACar.Application.Features.Brands.Commands.CreateBrands;
using rentACar.Application.Features.Brands.Queries.GetByIdBrand;
using rentACar.Application.Features.Brands.Queries.GetListBrand;

namespace rentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseClientController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommandRequest request)
        {
            CreatedBrandCommandResponse response = await Mediator.Send(request);
            return Created("", response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQueryRequest getListBrandQueryRequest = new() { PageRequest = pageRequest };
            GetListBrandQueryResponse result = await Mediator.Send(getListBrandQueryRequest);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQueryRequest request)
        {
            GetByIdBrandQueryResponse response = await Mediator.Send(request);

            return Ok(response);
        }
    }
}
