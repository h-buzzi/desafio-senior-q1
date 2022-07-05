using FilmeSeniorAPI.Models;
using Xunit.Abstractions;
using System.Collections.Generic;

namespace FilmesAPI.Testes
{
    public class MoviesByYearTeste : IDisposable
    {
        private MoviesByYear totalWithMovieYears;
        public ITestOutputHelper saidaConsoleTeste;
        private List<Movie> movieList;
        private List<MovieYearCount> years;
        private List<MovieYearCount> allMovies;
        private List<bool> result;



        public MoviesByYearTeste(ITestOutputHelper _saidaConsoleTeste)
        {
            this.saidaConsoleTeste = _saidaConsoleTeste;
            saidaConsoleTeste.WriteLine("Construtor Invocado");
            totalWithMovieYears = new MoviesByYear(-1);
            movieList = new List<Movie>();
            years = new List<MovieYearCount>();
            allMovies = new List<MovieYearCount>();
            result = new List<bool>();

        }

        [Theory]
        [MemberData(nameof(YearWithMovieCountData))]
        public void TestaContagemAnoListaFilmes(List<int> yearsMovies, List<int> yearRepetitions, List<int> eachYear)
        {
            foreach (int year in yearsMovies)
            {
                movieList.Add(new Movie("", year, ""));
            }
            for(int i = 0; i < yearRepetitions.Count; i++)
            {
                years.Add(new MovieYearCount(eachYear[i], yearRepetitions[i]));
            }
            totalWithMovieYears.addMoviesToYearsList(movieList);
            allMovies = totalWithMovieYears.getAllYearsCount();
            if (allMovies.Any()) {
                for(int i = 0; i < eachYear.Count(); i++)
                {
                    if (allMovies[i].getYear().Equals(years[i].getYear()) & allMovies[i].getMoviesCount().Equals(years[i].getMoviesCount()))
                    {
                        result.Add(true);
                    } else { result.Add(false); }
                }
                Assert.True(result.All<bool>(b => b.Equals(true)));
            } else
            {
                Assert.Empty(allMovies);
            }

        }

        public static IEnumerable<object[]> YearWithMovieCountData()
        {
            yield return new object[] { new List<int> { 1999, 1999, 1992, 1995, 1995 }, new List<int> { 2, 1, 2 }, new List<int> { 1999, 1992, 1995 } };
            yield return new object[] { new List<int> { -1 }, new List<int> { 1 }, new List<int> { -1 } };
            yield return new object[] { new List<int> {}, new List<int> { }, new List<int> { } };
        }
        public void Dispose()
        {
            saidaConsoleTeste.WriteLine("Dispose Invocado");
        }

    }
}
