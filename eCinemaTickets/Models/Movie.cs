namespace eCinemaTickets.Models
{
    using eCinemaTickets.Data.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


        // Relationships
        [Required]
        public List<ActorMovie> ActorsMovies { get; set; }

        
        [ForeignKey(nameof(Cinema))]
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }


        [ForeignKey(nameof(Producer))]
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}
