using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taskama.Pages.Model
{
    public class User
    {
        [Key] public Guid userId { get; set; }

        [Required][MaxLength(100)] public string username { get; set; }

        [Required][MaxLength(255)] public string passwordHash { get; set; }

        [Required][EmailAddress] public string email { get; set; }

        [Required] public DateTime createAt { get; set; }

        [Required] public bool isActive { get; set; }

        // Navigation Properties
        public virtual UserProfile? userProfile { get; set; }

        public virtual ICollection<Task>? assignedTasks { get; set; }
        public virtual ICollection<Comment>? comments { get; set; }
        public virtual ICollection<ProjectMember>? projectMembers { get; set; }
    }
}