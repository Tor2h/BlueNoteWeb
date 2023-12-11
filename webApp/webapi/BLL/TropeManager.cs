using Microsoft.Identity.Client;
using webapi.DAL;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.BLL
{
    public class TropeManager
    {
        private readonly IConfiguration _configuration;
        private readonly ITropeDB _tropeDB;
        public TropeManager(IConfiguration configuration)
        {
            _configuration = configuration;
            _tropeDB = new TropeDB(_configuration);
        }
        public async Task<List<Trope>> GetTropes()
        {
            List<Trope> tropes = await _tropeDB.GetTropes();
            return tropes;
        }
        public async Task<Trope> CreateTrope(Trope trope)
        {
            trope = await _tropeDB.CreateTrope(trope);
            return trope;
            
        }

    }
}
