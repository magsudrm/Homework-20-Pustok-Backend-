using System.ComponentModel.DataAnnotations;

namespace Pustok.ViewModels
{
    public class UserUpdateViewModel
    {
        [Required]
        [MaxLength(20)]
        [MinLength(4)]

        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MaxLength(35)]
        public string FullName { get; set; }

    }
}
