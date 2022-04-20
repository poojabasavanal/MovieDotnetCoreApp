using System;
using System.Collections.Generic;
using System.Text;
using MovieCoreApp.Entity.Models;

namespace MovieCoreApp.DAL.Repositories
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int movieId);
        Movie GetMovieById(int movieId);
        IEnumerable<Movie> GetMovies();
    }
}
