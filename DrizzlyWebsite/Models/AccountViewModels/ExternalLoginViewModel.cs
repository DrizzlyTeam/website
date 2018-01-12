using System.ComponentModel.DataAnnotations;

namespace DrizzlyWebsite.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
