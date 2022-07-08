using Newtonsoft.Json;

namespace FilmeSeniorAPI.Models
{
    public class HttpDatabaseResponse
    {
        private HttpClient httpClient;
        private bool failure;

        public HttpDatabaseResponse()
        {
            httpClient = new HttpClient();
            this.failure = false;
        }

        // Function responsible for sending the get request to the movies database, considering a indexed website.
        // It returns the respective DTO from the JSON.
        public async Task<JsonResponseAPI> getJsonFromDatabaseResponse(string movieName, int page)
        {
            var response = await httpClient.GetAsync(requestUri: $"https://jsonmock.hackerrank.com/api/movies/search/?Title={movieName}&page={page}");
            if (response.IsSuccessStatusCode & response != null) {
                var data = await response.Content.ReadAsStringAsync();
                if (data != null)
                {
                    try { 
                        JsonResponseAPI apiResponse = JsonConvert.DeserializeObject<JsonResponseAPI>(data);
                        return apiResponse;
                            }
                    catch (JsonException jsonExcept){
                        failure = true;
                        return new JsonResponseAPI();
                    }
                }
            }
            failure = true;
            return new JsonResponseAPI();
        }
        public bool getFailureStatus() { return failure; }
    }
}
