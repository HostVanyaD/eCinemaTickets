namespace eCinemaTickets.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        // Relationships
        [Required]
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
