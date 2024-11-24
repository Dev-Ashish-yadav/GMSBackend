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
        //update members
        [AllowAnonymous]
        [HttpPost("UpdateMembers")]
        public async Task<ActionResult<CommonResponse>> UpdateMembers(GymMemberUpdate.Query query)
        {
            return await Mediator.Send(query);
        }
        //getall members
        [AllowAnonymous]
        [HttpGet("GetAllMembers")]
        public async Task<ActionResult<CommonResponse>> GetAllMembers()
        {
            return await Mediator.Send(new GymMemberGetAll.Query());
        }
        //delete members
        [AllowAnonymous]
        [HttpPost("DeleteMembers")]
        public async Task<ActionResult<CommonResponse>> DeleteMembers(GymMemberDelete.Query query)
        {
            return await Mediator.Send(query);
        }
        //Get members based on id
        [AllowAnonymous]
        [HttpPost("GetMembersBasedOnId")]
        public async Task<ActionResult<CommonResponse>> GetMembersBasedOnId(GymMemberBasedOnID.Query query)
        {
            return await Mediator.Send(query);
        }
    }
}
