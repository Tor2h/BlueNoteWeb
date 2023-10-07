using webapi.Models;

namespace webapi.DAL.Interface
{
    public interface ITropeDB
    {
        public Task<List<Trope>> GetTropes();
    }
}
