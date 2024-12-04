using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taskama.Pages.Model
{
    public class ProjectMember
    {
        [Required] public Guid projectId { get; set; }

        [ForeignKey(nameof(projectId))] public virtual Project? project { get; set; }

        [Required] public Guid userId { get; set; }

        [ForeignKey(nameof(userId))] public virtual User? user { get; set; }

        [Required] public ProjectMemberRole role { get; set; }
    }
}