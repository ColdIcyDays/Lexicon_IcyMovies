namespace IcyMovies.Models.Viewmodels;

public class HomePageVM
{
    public List<Movie> HeroMovies { get; set; }
    public List<Movie> AllMovies { get; set; }

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
}