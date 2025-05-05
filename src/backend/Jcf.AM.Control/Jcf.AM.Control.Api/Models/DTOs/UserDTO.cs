using System.ComponentModel.DataAnnotations;

namespace Jcf.AM.Control.Api.Models.DTOs
{
    public class UserDTO : EntityBaseDTO
    {
        [StringLength(255)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Login { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        public string Role { get; set; } = string.Empty;

        public UserDTO() : base() { }
    }
}
