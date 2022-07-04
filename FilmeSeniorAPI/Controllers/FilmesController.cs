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
            HttpDatabaseResponse httpDatabaseResponse = new HttpDatabaseResponse();
            JsonResponseAPI apiResponse = await httpDatabaseResponse.getJsonFromDatabaseResponse(movieName, 1);
            MoviesByYear moviesByYear = new MoviesByYear(apiResponse.getTotal());
            moviesByYear.addMoviesToYearsList(apiResponse.getMovies());
            if (apiResponse.getTotalPages() > 1)
            {
                for (int i = 2; i<=apiResponse.getTotalPages(); i++)
                {
                    apiResponse = await httpDatabaseResponse.getJsonFromDatabaseResponse(movieName, i);
                    moviesByYear.addMoviesToYearsList(apiResponse.getMovies());
                }
            }
            return Ok(JsonConvert.SerializeObject(moviesByYear));
        }
    }
}
