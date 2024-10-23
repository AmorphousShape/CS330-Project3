namespace Fall2024_Assignment3_jbmcclenny.Models
{
public class MovieModel
    {
        public required string Title { get; set; }
        public required string MovieTitle { get; set; }
        public required string PosterUrl { get; set; }
        public required string ImdbLink { get; set; }
        public required string Genre { get; set; }
        public required string ReleaseYear { get; set; }
        public required string GeneralSentiment { get; set; }

        public class ReviewModel
        {
            public required string Author { get; set; }
            public required string Review { get; set; }
        }
        public required List<ReviewModel> ReviewsList { get; set; }
    }
}