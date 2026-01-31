using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2Modul.Dtos
{
    public class MovieDto
    {
            public string Title { get; set; }
            public string Director { get; set; }
            public int DurationMinutes { get; set; }
            public double Rating { get; set; }
            public long BoxOfficeEranings { get; set; }
            public DateTime RegisterTime { get; set; }
        
    }
}
