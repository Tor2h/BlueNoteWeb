﻿using webapi.DAL;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.BLL
{
    public class GenreManager
    {
        private readonly IConfiguration _configuration;
        private readonly IGenreDB _genreDB;
        public GenreManager(IConfiguration configuration)
        {
            _configuration = configuration;
            _genreDB = new GenreDB(_configuration);
        }
        public async Task<List<Genre>> GetGenres()
        {
            List<Genre> genres = await _genreDB.GetGenres();
            return genres;
        }
        public async Task<Genre> CreateGenre(Genre genre)
        {
            genre = await _genreDB.CreateGenre(genre);
            return genre;
        }

        public async Task<bool> DeleteGenre(Guid id)
        {
            bool genreDeleted = await _genreDB.DeleteGenre(id);
            return genreDeleted;
        }
    }
}
