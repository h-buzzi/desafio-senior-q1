using Newtonsoft.Json;

namespace FilmeSeniorAPI.Models
{
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

        public void addYearToList(int year)
        {
            int yearIndex = allYearsCount.FindIndex(mov => mov.getYear().Equals(year));
            if (yearIndex != -1){
                allYearsCount[yearIndex].incrementCount();
            } else
            {
                allYearsCount.Add(new MovieYearCount(year));
            }
        }

        //Setters and Getters below
        public int getTotalEntriesFound() { return totalEntriesFound; }
        public void setTotalEntriesFound(int totalEntriesFound) { this.totalEntriesFound = totalEntriesFound; }
        public List<MovieYearCount> getAllYearsCount() { return allYearsCount; }
        public void setAllYearsCount(List<MovieYearCount> allYearsCount) { this.allYearsCount = allYearsCount; }
    }
}
