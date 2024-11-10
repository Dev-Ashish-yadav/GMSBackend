using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymBackendServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAPIController : Controller
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? (
            _mediator = HttpContext.RequestServices.GetService<IMediator>()
            );
    }
}
