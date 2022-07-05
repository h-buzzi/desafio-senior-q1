using Newtonsoft.Json;

namespace FilmeSeniorAPI.Models
{
    public class MovieYearCount
    {
        [JsonProperty(PropertyName ="year")]
        private int year;
        [JsonProperty(PropertyName ="movies")]
        private int moviesCount;

        public MovieYearCount(int year)
        {
            this.year = year;
            this.moviesCount = 1;
        }

        public MovieYearCount(int year, int moviesCount)
        {
            this.year = year;
            this.moviesCount = moviesCount;
        }

        public void incrementCount()
        {
            this.moviesCount++;
        }

        //Setters and Getters below
        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }
        public int getMoviesCount() { return moviesCount; }
        public void setMoviesCount(int moviesCount) { this.moviesCount = moviesCount; }
    }
}
