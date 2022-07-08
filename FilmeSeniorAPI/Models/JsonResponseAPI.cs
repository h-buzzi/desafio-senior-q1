using Newtonsoft.Json;

namespace FilmeSeniorAPI.Models
{
    //Data Transfer Object from the expected JSON.
    public class JsonResponseAPI
    {
        [JsonProperty("page")]
        private int page;

        [JsonProperty("per_page")]
        private int perPage;

        [JsonProperty("total")]
        private int total;

        [JsonProperty("total_pages")]
        private int totalPages;

        [JsonProperty("data")]
        private List<Movie> movies;

        //Setters and Getters below
        public int getPage() { return page; }
        public void setPage(int page) { this.page = page; }
        public int getPerPage() { return perPage; }
        public void setPerPage(int perPage) { this.perPage = perPage; }
        public int getTotal() { return total; }
        public void setTotal(int total) { this.total = total; }
        public int getTotalPages() { return totalPages; }
        public void setTotalPages(int totalPages) { this.totalPages = totalPages; }
        public List<Movie> getMovies() { return movies; }
        public void setMovies(List<Movie> movies) { this.movies = movies; }


    }
}
