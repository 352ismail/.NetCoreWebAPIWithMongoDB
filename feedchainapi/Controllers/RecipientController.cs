using feedchainapi.Domain.IServices;
using feedchainapi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace feedchainapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipientController : ControllerBase
    {
        private readonly IRecipientService _recipientService;
        public RecipientController(IRecipientService recipientService)
        {
            _recipientService = recipientService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllReciepent()
        {
            return Ok();
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(string Id)
        {
            return Ok();
        }
        [HttpGet("Filters")]
        public async Task<IActionResult> Filters([FromQuery]
            string? Name,
            string? FatherName,
            string? CNIC,
            string? Village,
            string? FullAddress,
            string? MobileNumber,
            string? Gender)
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReciepentViewModel model)
        {
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] string Id ,[FromBody] CreateReciepentViewModel model)
        {
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] string Id)
        {
            return Ok();
        }
    }
}
