using Newtonsoft.Json;

namespace FilmeSeniorAPI.Models
{
    public class HttpDatabaseResponse
    {
        HttpClient httpClient = new HttpClient();
        public async Task<JsonResponseAPI> getJsonFromDatabaseResponse(string movieName, int page)
        {
            var response = await httpClient.GetAsync(requestUri: $"https://jsonmock.hackerrank.com/api/movies/search/?Title={movieName}&page={page}");
            if (response.IsSuccessStatusCode) {
                var data = await response.Content.ReadAsStringAsync();
                if (data != null)
                {
                    try { 
                        JsonResponseAPI apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
                        return apiResponse;
                            }
                    catch { }
                }
            }
            return new JsonResponseAPI();
        }
    }
}
