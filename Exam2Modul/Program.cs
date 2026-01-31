using Exam2Modul.Dtos;
using Exam2Modul.Etiteis;
using Exam2Modul.Services;

namespace Exam2Modul
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void Main()
            {
                MovieService service = new MovieService();

                service.Create(new Movie
                {
                    Id = Guid.NewGuid(),
                    Title = "Interstellar",
                    Director = "Nolan",
                    DurationMinutes = 169,
                    Rating = 9.0,
                    BoxOfficeEranings = 700000000,
                    RegisterTime = new DateTime(2014, 1, 1)
                });

                MovieDto top = service.GetTopRetedMovie();
                Console.WriteLine(top.Title);
            }
        }
    }
}
