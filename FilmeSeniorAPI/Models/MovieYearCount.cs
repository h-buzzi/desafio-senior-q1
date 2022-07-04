namespace FilmeSeniorAPI.Models
{
    public class MovieYearCount
    {
        private int year;
        private int moviesCount;

        //Setters and Getters below
        public int getYear() { return year; }
        public void setYear(int year) { this.year = year; }
        public int getMoviesCount() { return moviesCount; }
        public void setMoviesCount(int moviesCount) { this.moviesCount = moviesCount; }
    }
}
