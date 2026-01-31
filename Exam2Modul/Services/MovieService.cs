using Exam2Modul.Dtos;
using Exam2Modul.Etiteis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2Modul.Services
{
    class MovieService : IMovieService
    {
        private List<Movie> movies = new List<Movie>();

        
        public void Create(Movie movie)
        {
            movies.Add(movie);
        }

        public void Update(Movie movie)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Id == movie.Id)
                {
                    movies[i] = movie;
                    return;
                }
            }
        }

        public void Delete(Guid id)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Id == id)
                {
                    movies.RemoveAt(i);
                    return;
                }
            }
        }

        
        public List<MovieDto> GetAllMoviesByDirector(string director)
        {
            List<MovieDto> result = new List<MovieDto>();

            foreach (var movie in movies)
            {
                if (movie.Director == director)
                    result.Add(movie.ToDto());
            }

            return result;
        }

        public MovieDto GetTopRetedMovie()
        {
            Movie top = movies[0];

            foreach (var movie in movies)
            {
                if (movie.Rating > top.Rating)
                    top = movie;
            }

            return top.ToDto();
        }

        public List<MovieDto> GetMoviesReleasedAfterYear(int year)
        {
            List<MovieDto> result = new List<MovieDto>();

            foreach (var movie in movies)
            {
                if (movie.RegisterTime.Year > year)
                    result.Add(movie.ToDto());
            }

            return result;
        }

        public MovieDto GetHighestGrossingMovie()
        {
            Movie max = movies[0];

            foreach (var movie in movies)
            {
                if (movie.BoxOfficeEranings > max.BoxOfficeEranings)
                    max = movie;
            }

            return max.ToDto();
        }

        public List<MovieDto> SearchMovieByTitle(string keyword)
        {
            List<MovieDto> result = new List<MovieDto>();

            foreach (var movie in movies)
            {
                if (movie.Title.ToLower().Contains(keyword.ToLower()))
                    result.Add(movie.ToDto());
            }

            return result;
        }

        public List<MovieDto> GetMoviesWithDurationRange(int minMinutes, int maxMinutes)
        {
            List<MovieDto> result = new List<MovieDto>();

            foreach (var movie in movies)
            {
                if (movie.DurationMinutes >= minMinutes &&
                    movie.DurationMinutes <= maxMinutes)
                    result.Add(movie.ToDto());
            }

            return result;
        }

        public long GetTotalBoxOfficeEarnningsByDirector(string director)
        {
            long sum = 0;

            foreach (var movie in movies)
            {
                if (movie.Director == director)
                    sum += movie.BoxOfficeEranings;
            }

            return sum;
        }

        public List<MovieDto> GetMoviesSortedByRating()
        {
            List<Movie> temp = new List<Movie>(movies);

            for (int i = 0; i < temp.Count - 1; i++)
            {
                for (int j = i + 1; j < temp.Count; j++)
                {
                    if (temp[i].Rating < temp[j].Rating)
                    {
                        var t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }

            List<MovieDto> result = new List<MovieDto>();
            foreach (var movie in temp)
                result.Add(movie.ToDto());

            return result;
        }

        public List<MovieDto> GetRecentMovies(int year)
        {
            List<MovieDto> result = new List<MovieDto>();

            foreach (var movie in movies)
            {
                if (movie.RegisterTime.Year >= year)
                    result.Add(movie.ToDto());
            }

            return result;

            


        }

        public List<MovieDto> GetMoviesReleasedAfterYear(string director)
        {
            throw new NotImplementedException();
        }
    }
}
