using FilmeSeniorAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FilmeSeniorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmesController : ControllerBase
    {

        [HttpGet("{movieName}")]
        public async Task<IActionResult> getMovieByName(string movieName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestUri: $"https://jsonmock.hackerrank.com/api/movies/search/?Title={movieName}");
            var data = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
            MoviesByYear moviesByYear = new MoviesByYear(apiResponse.getTotal());
            foreach (Movie movie in apiResponse.getMovies())
            {
                moviesByYear.addYearToList(movie.getYear());
            }
            if (apiResponse.getTotalPages() > 1)
            {
                for (int i = 2; i<=apiResponse.getTotalPages(); i++)
                {
                    response = await httpClient.GetAsync(requestUri: $"https://jsonmock.hackerrank.com/api/movies/search/?Title={movieName}&page={i}");
                    data = await response.Content.ReadAsStringAsync();
                    apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
                    foreach (Movie movie in apiResponse.getMovies())
                    {
                        moviesByYear.addYearToList(movie.getYear());
                    }
                }
            }
            return Ok(JsonConvert.SerializeObject(moviesByYear));
        }
    }
}
