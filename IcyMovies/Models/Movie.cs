namespace IcyMovies.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public int AgeRating { get; set; }
    public int DurationInMinutes { get; set; }
    public string PosterURL { get; set; }
    public string Description { get; set; }
    public string ShortDescription { get; set; }
}