using Newtonsoft.Json;
namespace FilmeSeniorAPI.Models
{
    public class Movie
    {
        [JsonProperty("Title")]
        private string title;

        [JsonProperty("Year")]
        private int year;

        [JsonProperty("imdbID")]
        private string imdbID;

        public Movie(string title, int year, string imdbID)
        {
            this.title = title;
            this.year = year;
            this.imdbID = imdbID;
        }



        //Setter and Getters below
        public string getTitle() { return title; }
        public void setTitle(string title) { this.title = title; }
        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }
        public string getImdbID() { return imdbID; }
        public void setId(string imdbID) { this.imdbID = imdbID; }
    }
}
