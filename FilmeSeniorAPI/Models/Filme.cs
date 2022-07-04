using Newtonsoft.Json;
namespace FilmeSeniorAPI.Models
{
    public class Filme
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Year")]
        public int Year { get; set; }

        [JsonProperty("imdbID")]
        public string ImdbID { get; set; }
    }
}
