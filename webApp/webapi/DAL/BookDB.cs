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
        public async Task<List<Book>> GetBooks()
        {
            var books = new List<Book>();

            string query = @"Select * Book from dbo.Book";
            DataTable dataTable = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("ConnectMsSqlString");
            SqlDataReader myReader;

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteNonQuery();
                    dataTable.Load(myReader);

                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        Book book = new Book();
                        book.AaName = dataRow[0].ToString();
                        book.Author = dataRow[1].ToString();
                        book.Series = dataRow[2].ToString();
                        string boolString = dataRow[3].ToString();
                        if (boolString == "true")
                        {
                            book.OwnedOrWish = true;
                        }
                        else
                        {
                            book.OwnedOrWish = false;
                        }
                        book.Status = dataRow[4].ToString();
                        books.Add(dataRow);
                    }
                }
            }

            return books;
        }
    }
}
