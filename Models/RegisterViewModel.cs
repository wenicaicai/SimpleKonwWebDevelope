using System.ComponentModel.DataAnnotations;

namespace SimpleKonwWebDevelope.Models
{
    public class RegisterViewModel
    {
        [Required, MaxLength(30)]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
