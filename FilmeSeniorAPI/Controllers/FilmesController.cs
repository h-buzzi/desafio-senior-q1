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
        public static List<Filme> filmes = new List<Filme>();

        [HttpGet]
        public async void getFilmes()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestUri: "https://jsonmock.hackerrank.com/api/movies/search/?Title=Waterworld");
            var data = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
            Console.WriteLine(apiResponse.Filmes[0].ImdbID);
        }
    }
}
