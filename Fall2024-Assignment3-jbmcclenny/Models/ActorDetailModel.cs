namespace Fall2024_Assignment3_jbmcclenny.Models {
    public class ActorDetailViewModel {
        public int Id { get; set; }
        public ActorViewModel? Actor { get; set; }
        public List<MovieViewModel>? Movies { get; set; }

        public ActorDetailViewModel(ActorViewModel actor, List<MovieViewModel> movies) {
            Id = actor.Id;
            Actor = actor;
            Movies = movies;
        }
    }
}