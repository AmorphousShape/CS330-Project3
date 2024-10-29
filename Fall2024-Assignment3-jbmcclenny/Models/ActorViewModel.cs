using System.ComponentModel.DataAnnotations;

namespace Fall2024_Assignment3_jbmcclenny.Models
{
    public class ActorViewModel {

        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? HeadshotUrl { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? TwitterSentiment { get; set; }

        public class TweetModel {

            [Key]
            public int Id { get; set; }
            public string? Tweet { get; set; }
            public string? Author { get; set; }
        }   
        public List<TweetModel>? Tweets { get; set; }
    }
}