using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Data;
using System.Data.SqlClient;
using webapi.BLL;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.DAL
{
    public class BookDB : IBookDB
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        public BookDB(ILogger logger, IConfiguration configuration)
        {
            this._logger = logger;
            this._configuration = configuration;
        }
        
    }
}
