namespace Fall2024_Assignment3_jbmcclenny.Models {
    public class ActorViewModel {
        public required string ActorName { get; set; }
        public required string HeadshotUrl { get; set; }
        public required string Gender { get; set; }
        public required int Age { get; set; }
        public class MovieModel {
            public required string MovieTitle { get; set; }
            public required string Role { get; set; }
        }
        public required List<MovieModel> Movies { get; set; }
        public required string TwitterSentiment { get; set; }
        public class TweetModel {
            public required string Tweet { get; set; }
            public required string Author { get; set; }
        }   

    }
}