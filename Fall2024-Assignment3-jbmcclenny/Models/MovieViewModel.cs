using System.ComponentModel.DataAnnotations;

namespace Fall2024_Assignment3_jbmcclenny.Models
{
public class MovieViewModel
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string PosterUrl { get; set; }
        public required string ImdbLink { get; set; }
        public required string Genre { get; set; }
        public required string ReleaseYear { get; set; }

        public class ActorModel
        {
            public required string ActorName { get; set; }
            public required string Role { get; set; }
            public required string Link { get; set; }
        }
        public required List<ActorModel> ActorsList { get; set; }
        public required string GeneralSentiment { get; set; }

        public class ReviewModel
        {
            public required string Author { get; set; }
            public required string Review { get; set; }
        }
        public required List<ReviewModel> ReviewsList { get; set; }
    }
}