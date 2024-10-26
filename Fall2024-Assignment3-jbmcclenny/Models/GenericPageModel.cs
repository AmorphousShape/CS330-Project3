namespace Fall2024_Assignment3_jbmcclenny.Models
{
    public class CreatePageViewModel
    {
        public string PageType { get; set; }
        public ActorViewModel Actor { get; set; }
        public MovieViewModel Movie { get; set; }

        public CreatePageViewModel(string pageType, ActorViewModel actor, MovieViewModel movie)
        {
            PageType = pageType ?? throw new ArgumentNullException(nameof(pageType));
            Actor = actor ?? throw new ArgumentNullException(nameof(actor));
            Movie = movie ?? throw new ArgumentNullException(nameof(movie));
        }
    }
}