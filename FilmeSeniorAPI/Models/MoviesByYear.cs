namespace FilmeSeniorAPI.Models
{
    public class MoviesByYear
    {
        private int totalEntriesFound;

        private List<MovieYearCount> allYearsCount;

        //Setters and Getters below
        public int getTotalEntriesFound() { return totalEntriesFound; }
        public void setTotalEntriesFound(int totalEntriesFound) { this.totalEntriesFound = totalEntriesFound; }
        public List<MovieYearCount> getAllYearsCount() { return allYearsCount; }
        public void setAllYearsCount(List<MovieYearCount> allYearsCount) { this.allYearsCount = allYearsCount; }
    }
}
