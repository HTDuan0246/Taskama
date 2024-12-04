using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taskama.Pages.Model
{
    public class Project
    {
        [Key] public Guid projectId { get; set; }

        [Required][StringLength(100)] public string projectName { get; set; }

        [StringLength(1000)] public string description { get; set; }

        [Required] public DateTime createdAt { get; set; }

        [Required] public ProjectStatus status { get; set; }

        // Navigation Properties
        public virtual ICollection<Task>? tasks { get; set; }

        public virtual ICollection<ProjectMember>? members { get; set; }
    }
}