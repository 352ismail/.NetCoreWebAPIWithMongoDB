using feedchainapi.Domain.IServices;
using feedchainapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace feedchainapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _feedChainService;
        public UsersController(IUsersService feedChainService)
        {
            _feedChainService = feedChainService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string Id)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Register()
        {
            return Ok();
        }
    }
}
