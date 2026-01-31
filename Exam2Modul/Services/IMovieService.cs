using Exam2Modul.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2Modul.Services;

    public interface IMovieService
    {
    public List<MovieDto> GetAllMoviesByDirector(string director);
    public MovieDto GetTopRetedMovie();
    public List<MovieDto> GetMoviesReleasedAfterYear(string director);
    public MovieDto GetHighestGrossingMovie();
    public List<MovieDto> SearchMovieByTitle(string keyword);
    public List<MovieDto> GetMoviesWithDurationRange(int minMinutes, int maxMinutes);
    public long GetTotalBoxOfficeEarnningsByDirector (string director);
    public List<MovieDto> GetMoviesSortedByRating();
    public List<MovieDto> GetRecentMovies(int year);
}
