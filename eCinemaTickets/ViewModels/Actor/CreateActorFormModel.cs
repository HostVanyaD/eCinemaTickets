namespace eCinemaTickets.ViewModels.Actor
{
    using System.ComponentModel.DataAnnotations;

    public class CreateActorFormModel
    {
        [Required]
        [Url]
        public string ProfilePictureURL { get; set; }

        [Required, ]
        [StringLength(
            30,
            MinimumLength = 2,
            ErrorMessage = "Name must be a text with a minimum length of {2} and maximum length {1}.")]
        public string FullName { get; set; }

        [Required]
        [StringLength(
            200000,
            MinimumLength = 10,
            ErrorMessage = "Biography must be a text with a minimum length of {2} and maximum length {1}.")]
        public string Bio { get; set; }
    }
}
