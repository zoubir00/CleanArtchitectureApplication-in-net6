using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet("Get all members")]
        public IActionResult GetAllMemebers()
        {
            var allMemebers = _memberService.GetAllMembers();
            return Ok(allMemebers);
        }
    }
}
