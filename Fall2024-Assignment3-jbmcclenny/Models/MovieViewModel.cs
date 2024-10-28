using System.ComponentModel.DataAnnotations;

namespace Fall2024_Assignment3_jbmcclenny.Models
{
public class MovieViewModel
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PosterUrl { get; set; }
    public string? ImdbLink { get; set; }
    public string? Genre { get; set; }
    public string? ReleaseYear { get; set; }
    public List<string>? ActorsList { get; set; }
    public string? GeneralSentiment { get; set; }

    public class ReviewModel
    {
        public string? Author { get; set; }
        public string? Review { get; set; }
    }
    public List<ReviewModel>? ReviewsList { get; set; }
}
}