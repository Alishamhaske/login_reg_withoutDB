using System.ComponentModel.DataAnnotations;

namespace login_reg_withoutDB.Models
{
    public class User
    {

        [Required]
        public string? Username { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(30)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

    }
}
