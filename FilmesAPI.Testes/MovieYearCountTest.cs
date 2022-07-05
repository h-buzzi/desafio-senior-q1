using FilmeSeniorAPI.Models;
using Xunit.Abstractions;

namespace FilmesAPI.Testes
{
    public class MovieYearCountTest : IDisposable
    {
        private MovieYearCount yearWithMovieCount;
        public ITestOutputHelper saidaConsoleTeste;

        public MovieYearCountTest(ITestOutputHelper _saidaConsoleTeste)
        {
            this.saidaConsoleTeste = _saidaConsoleTeste;
            saidaConsoleTeste.WriteLine("Construtor Invocado");
            yearWithMovieCount = new MovieYearCount(1999);
        }

        [Fact(DisplayName = "TesteCriaçãoAnoComContadorInicial")]
        public void TestaAnoIncremento()
        {
            //Arrange
            //Act
            yearWithMovieCount.incrementCount();
            //Assert
            Assert.Equal(2,yearWithMovieCount.getMoviesCount());
        }

        [Theory(DisplayName = "TesteContadorAnoComValoresDiferentes")]
        [InlineData(3)]
        [InlineData(10)]
        [InlineData(0)]
        [InlineData(-1)]
        public void TestaAnoIncrementoValorPreExistente(int count)
        {
            //Arrange
            yearWithMovieCount.setMoviesCount(count);
            //Act
            yearWithMovieCount.incrementCount();
            //Assert
            Assert.Equal(count + 1, yearWithMovieCount.getMoviesCount());
        }

        public void Dispose()
        {
            saidaConsoleTeste.WriteLine("Dispose Invocado");
        }
    }
}