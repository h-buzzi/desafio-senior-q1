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
        public async void getMovieByName(string movieName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestUri: $"https://jsonmock.hackerrank.com/api/movies/search/?Title={movieName}");
            var data = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
            List<Movie> movies = apiResponse.getMovies();
            Console.WriteLine(movies[0].getImdbID());
        }
    }
}
