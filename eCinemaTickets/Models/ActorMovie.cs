namespace eCinemaTickets.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ActorMovie
    {
        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey(nameof(Actor))]
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
