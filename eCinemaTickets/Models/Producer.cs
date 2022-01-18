namespace eCinemaTickets.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProfilePictureURL { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Bio { get; set; }

        // Relationships
        [Required]
        public List<Movie> Movies { get; set; }
    }
}
