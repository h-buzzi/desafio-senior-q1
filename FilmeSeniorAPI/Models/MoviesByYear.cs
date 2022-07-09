using Newtonsoft.Json;

namespace FilmeSeniorAPI.Models
{
    //Output object from this API
    public class MoviesByYear
    {
        [JsonProperty(PropertyName = "total")]
        private int totalEntriesFound;
        [JsonProperty(PropertyName ="moviesByYear")]
        private List<MovieYearCount> allYearsCount;

        public MoviesByYear(int totalEntriesFound)
        {
            this.totalEntriesFound = totalEntriesFound;
            this.allYearsCount = new List<MovieYearCount>();
        }

        // Function responsible for adding new years or incrementing the count of an existing year from an list of movies.
        public void addMoviesToYearsList(List<Movie> movies)
        {
            foreach (Movie movie in movies)
                {
                 int yearIndex = allYearsCount.FindIndex(previousFoundMovies => previousFoundMovies.getYear().Equals(movie.getYear()));
                    if (yearIndex != -1)
                    {
                        allYearsCount[yearIndex].incrementCount();
                    }
                    else
                    {
                        allYearsCount.Add(new MovieYearCount(movie.getYear()));
                    }
                }
        }

        // Function responsible for making the list of year in crescent order
        public void sortListByYear()
        {
            allYearsCount.Sort((x,y) =>x.getYear().CompareTo(y.getYear()));
        }

        //Setters and Getters below
        public int getTotalEntriesFound() { return totalEntriesFound; }
        public void setTotalEntriesFound(int totalEntriesFound) { this.totalEntriesFound = totalEntriesFound; }
        public List<MovieYearCount> getAllYearsCount() { return allYearsCount; }
        public void setAllYearsCount(List<MovieYearCount> allYearsCount) { this.allYearsCount = allYearsCount; }
    }
}
