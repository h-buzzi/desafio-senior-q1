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
        // This function is responsible of collecting a JSON from a WebAPI about movies through the usage of an input string.
        // The function returns an object that contain the total entries found,
        // as well as a list containing the years found and the respective movies found in it.
        [HttpGet("{movieName}")]
        public async Task<IActionResult> getMovieByName(string movieName)
        {
            HttpDatabaseResponse httpDatabaseResponse = new HttpDatabaseResponse();
            JsonResponseAPI apiResponse = await httpDatabaseResponse.getJsonFromDatabaseResponse(movieName, 1);
            if (httpDatabaseResponse.getFailureStatus().Equals(true)) 
            {
                return NotFound();
            }
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
            moviesByYear.sortListByYear();
            return Ok(JsonConvert.SerializeObject(moviesByYear));
        }
    }
}
