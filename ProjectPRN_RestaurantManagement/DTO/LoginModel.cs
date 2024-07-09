using System.ComponentModel.DataAnnotations;

namespace ProjectPRN_RestaurantManagement.DTO
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
