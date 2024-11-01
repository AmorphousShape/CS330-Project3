using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fall2024_Assignment3_jbmcclenny.Models;

//[PrimaryKey("MovieId", "ActorId")]
public class MovieActorViewModel
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Movie")]
    public int MovieId { get; set; }

    public MovieViewModel? Movie { get; set; }

    [ForeignKey("Actor")]
    public int ActorId { get; set; }

    public ActorViewModel? Actor { get; set; }
}
