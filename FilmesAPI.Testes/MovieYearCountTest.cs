using FilmeSeniorAPI.Models;

namespace FilmesAPI.Testes
{
    public class MovieYearCountTest
    {
        [Fact]
        public void TestaAnoIncremento()
        {
            //Arrange
            MovieYearCount movieYear = new MovieYearCount(1999);
            //Act
            movieYear.incrementCount();
            //Assert
            Assert.Equal(2,movieYear.getMoviesCount());
        }
    }
}