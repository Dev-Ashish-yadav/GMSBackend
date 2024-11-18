using Domain.Models;
using GymBackendServices.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymBackendServices.Controllers
{
    public class GymMemberController : BaseAPIController
    {
        [AllowAnonymous]
        [HttpPost("AddMembers")]
        public async Task<ActionResult<CommonResponse>> AddUser(GymMemberHandler.Query query)
        {
            return await Mediator.Send(query);
        }
    }
}
