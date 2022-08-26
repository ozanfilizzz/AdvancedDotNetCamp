using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rentACar.Application.Features.Brands.Commands.CreateBrands;

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
    }
}
