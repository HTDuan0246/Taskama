using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taskama.Pages.Model
{
    public class UserProfile
    {
        [Key] public Guid id { get; set; }

        [Required] public Guid userId { get; set; }

        [ForeignKey(nameof(userId))] public virtual User? user { get; set; }

        [Required][StringLength(100)] public string fullName { get; set; }

        [StringLength(500)] public string? avatarUrl { get; set; }

        [Phone][StringLength(20)] public string? phoneNumber { get; set; }

        [StringLength(1000)] public string? bio { get; set; }
    }
}