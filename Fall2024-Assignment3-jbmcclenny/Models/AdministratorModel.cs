namespace Fall2024_Assignment3_jbmcclenny.Models
{
    public class AdministratorModel
    {
        public string PageType { get; set; }
        public ActorViewModel Actor { get; set; }
        public MovieViewModel Movie { get; set; }

        public AdministratorModel(string pageType, ActorViewModel actor, MovieViewModel movie)
        {
            PageType = pageType ?? throw new ArgumentNullException(nameof(pageType));
            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
            Movie = movie ?? throw new ArgumentNullException(nameof(movie));
        }
    }
}