using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [Controller]
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
        public async Task<ActionResult<Trope>> CreateTrope(string tropeName) 
        {
            var trope = await _tropeManager.CreateTrope(tropeName);
            return Ok(trope);
        }
    }
}
