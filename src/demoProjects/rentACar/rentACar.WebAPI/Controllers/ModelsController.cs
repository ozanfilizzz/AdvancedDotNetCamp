using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rentACar.Application.Features.Brands.Queries.GetListBrand;
using rentACar.Application.Features.Models.Queries.GetListModel;
using rentACar.Application.Features.Models.Queries.GetListModelByDynamic;

namespace rentACar.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseClientController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQueryRequest getListModelQueryRequest = new() { PageRequest = pageRequest };
            GetListModelQueryResponse result = await Mediator.Send(getListModelQueryRequest);
            return Ok(result);
        }

        [HttpPost("GetList/ByDynamic")]
        public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] Dynamic dynamic)
        {
            GetListModelByDynamicQueryRequest getListModelByDynamicQueryRequest = new() { PageRequest = pageRequest, Dynamic = dynamic };
            GetListModelByDynamicQueryResponse result = await Mediator.Send(getListModelByDynamicQueryRequest);
            return Ok(result);
        }
    }
}
