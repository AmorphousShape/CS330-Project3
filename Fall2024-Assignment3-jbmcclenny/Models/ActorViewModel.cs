namespace Fall2024_Assignment3_jbmcclenny.Models {
    public class ActorViewModel {
        public int Id { get; set; }
        public string? ActorName { get; set; }
        public string? HeadshotUrl { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public class MovieModel {
            public string? MovieTitle { get; set; }
            public string? Role { get; set; }
        }
        public string? TwitterSentiment { get; set; }
        public class TweetModel {
            public string? Tweet { get; set; }
            public string? Author { get; set; }
        }   
        public List<TweetModel>? Tweets { get; set; }
    }
}