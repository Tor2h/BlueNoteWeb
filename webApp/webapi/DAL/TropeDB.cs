

using Microsoft.EntityFrameworkCore;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.DAL
{
    public class TropeDB : ITropeDB
    {
        private readonly IConfiguration _configuration;
        public TropeDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<Trope>> GetTropes()
        {
            List<Trope> tropes = new List<Trope>();
            using (var db = new DatabaseContext(_configuration))
            {
                tropes = await db.Tropes.ToListAsync();
            }
            return tropes;
        }
        public async Task<Trope> CreateTrope(Trope trope)
        {
            trope.ID = Guid.NewGuid();
            using (var db = new DatabaseContext(_configuration))
            {
                db.Tropes.Add(trope);
                _ = await db.SaveChangesAsync();
            }
            return trope;
        }
    }
}
