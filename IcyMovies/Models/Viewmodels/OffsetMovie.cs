namespace IcyMovies.Models.Viewmodels;

public class OffsetMovie
{
    public List<Movie> FoundMovies { get; set; }
    public int Offset { get; set; }
    public int TotalMovieCount { get; set; }
    public int PaginationCount { get; set; }
    public string NameFilter { get; set; } = "";
}