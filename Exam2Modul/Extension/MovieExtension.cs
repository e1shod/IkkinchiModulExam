using Exam2Modul.Dtos;
using Exam2Modul.Etiteis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2Modul.Extension
{
    static class MovieExtensions
    {
        public static MovieDto ToDto(this Movie movie)
        {
            return new MovieDto
            {
                Title = movie.Title,
                Director = movie.Director,
                DurationMinutes = movie.DurationMinutes,
                Rating = movie.Rating,
                BoxOfficeEranings = movie.BoxOfficeEranings,
                RegisterTime = movie.RegisterTime
            };
        }


        public static double GetDurationInHours(this MovieDto movie)
        {
            return movie.DurationMinutes / 60.0;
        }


        public static long GetTotalBoxOffice(this List<MovieDto> movies)
        {
            long sum = 0;
            foreach (var movie in movies)
                sum += movie.BoxOfficeEranings;

            return sum;
        }
    }
}
