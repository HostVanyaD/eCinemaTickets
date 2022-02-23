namespace eCinemaTickets.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Profile picture")]
        public string ProfilePictureURL { get; set; }

        [Required]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        // Relationships
        [Required]
        public List<Movie> Movies { get; set; }
    }
}
