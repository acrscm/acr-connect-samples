using System.ComponentModel.DataAnnotations;

namespace Acr.Connect.Samples.Mvc.BasicAuthentication.Models
{
    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}