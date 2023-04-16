using System.ComponentModel.DataAnnotations;

namespace GameMaster.UI.Models
{
    public class UserViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
