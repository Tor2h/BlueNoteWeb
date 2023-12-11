using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    public class TropeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly TropeManager _tropeManager;
        public TropeController(IConfiguration configuration)
        {
            _configuration = configuration;
            _tropeManager = new TropeManager(_configuration);
        }
        [HttpGet]
        [Route("/tropes")]
        public async Task<ActionResult<List<Trope>>> GetTropes()
        {
            var tropes = await _tropeManager.GetTropes();
            return Ok(tropes);
        }
        [HttpPost]
        [Route("/tropes")]
        public async Task<ActionResult<Trope>> CreateTrope(Trope trope) 
        {
            var result = await _tropeManager.CreateTrope(trope);
            return Ok(result);
        }
    }
}
