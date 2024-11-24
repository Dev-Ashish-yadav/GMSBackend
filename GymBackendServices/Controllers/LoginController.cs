using Domain.Models;
using GymBackendServices.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymBackendServices.Controllers
{
    public class LoginController : BaseAPIController
    {

        [AllowAnonymous]
        [HttpPost("LoginAdmin")]
        public async Task<ActionResult<CommonResponse>> LoginAdmin(GymAdminHandler.Query query)
        {
            return await Mediator.Send(query);
        }
    }
}
