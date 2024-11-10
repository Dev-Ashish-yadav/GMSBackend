using Domain.Models;
using GymBackendServices.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymBackendServices.Controllers
{
    public class GymUserController : BaseAPIController
    {
        [AllowAnonymous]
        [HttpPost("AddUser")]
        public async Task<ActionResult<CommonResponse>> AddUser(GymUserHandler.Query query)
        {
            return await Mediator.Send(query);
        }
    }
}
