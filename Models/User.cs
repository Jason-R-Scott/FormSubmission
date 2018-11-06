using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Range(1,125)]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password {get;set;}
    }
}