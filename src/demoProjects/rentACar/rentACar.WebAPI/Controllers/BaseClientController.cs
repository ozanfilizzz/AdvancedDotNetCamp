using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace rentACar.WebAPI.Controllers
{
    public class BaseClientController : ControllerBase
    {
        protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
        private IMediator? _mediator;
    }
}
