namespace IcyMovies.Models;

public class Review
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public Movie TargetMovie { get; set; }
    public string ReviewTitle { get; set; }
    public string ReviewBody { get; set; }
}