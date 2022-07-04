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

        [HttpGet]
        public async void getFilmes()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestUri: "https://jsonmock.hackerrank.com/api/movies/search/?Title=Waterworld");
            var data = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
            List<Movie> movies = apiResponse.getMovies();
            Console.WriteLine(movies[0].getImdbID());
        }
    }
}
