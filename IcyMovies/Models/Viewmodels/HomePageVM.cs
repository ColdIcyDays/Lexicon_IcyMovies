namespace IcyMovies.Models.Viewmodels;

public class HomePageVM
{
    public List<Movie> HeroMovies { private get; set; } = new List<Movie>();
    public List<Movie> AllMovies { private get; set; } = new List<Movie>();

    public List<Movie> GetMoviesByGenre(string aGenre)
    {
        List<Movie> result = new List<Movie>();
        foreach (Movie mov in AllMovies)
        {
            if (mov.Genre.ToLower().Contains(aGenre.ToLower()))
            {
                result.Add(mov);
            }
        }

        return result;
    }

    public Movie? GetHeroMovie(int aIndex)
    {
        return HeroMovies.Count > aIndex ? HeroMovies[aIndex] : null;
    }
}