using webapi.Models;

namespace webapi.DAL.Interface
{
    public interface ITropeDB
    {
        public Task<List<Trope>> GetTropes();
        public Task<Trope> CreateTrope(Trope trope);
        public Task<bool> DeleteTrope(Guid id);
    }
}
