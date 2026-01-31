using Exam2Modul.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2Modul.Etiteis
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int DurationMinutes { get; set; }
        public double Rating { get; set; }
        public long BoxOfficeEranings { get; set; }
        public DateTime RegisterTime { get; set; }

        internal MovieDto ToDto()
        {
            throw new NotImplementedException();
        }
    }
}
