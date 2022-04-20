using System;
using System.Collections.Generic;
using System.Text;
using MovieCoreApp.DAL.Repositories;
using MovieCoreApp.Entity.Models;

namespace MovieCoreApp.BAL.services
{
    public class MovieService
    {
        IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        //add movie
        public void AddMoive(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }
        //update movie
        public void UpdateMoive(Movie movie)
        {
            _movieRepository.UpdateMovie(movie);
        }
        //delete movie
        public void DeleteMovie(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }
        //Get GetMovieByid
        public void GetMovieByid(int movieId)
        {
            _movieRepository.GetMovieById(movieId);
        }
        //Get GetMovies
        public IEnumerable<Movie> GetMovies()
        {
            return _movieRepository.GetMovies();
        }
    }
}
