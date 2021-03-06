namespace eCinemaTickets.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile Picture")]
        [Url]
        public string ProfilePictureURL { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(
            30,
            MinimumLength = 2,
            ErrorMessage = "Name must be a text with a minimum length of {2} and maximum length {1}.")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Biography")]
        [StringLength(
            200000,
            MinimumLength = 10,
            ErrorMessage = "Biography must be a text with a minimum length of {2} and maximum length {1}.")]
        public string Bio { get; set; }


        // Relationships
        [Required]
        public List<ActorMovie> ActorMovies { get; set; }
    }
}
