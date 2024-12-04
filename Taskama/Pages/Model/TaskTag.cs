using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taskama.Pages.Model
{
    public class TaskTag
    {
        [Required] public Guid taskId { get; set; }

        [ForeignKey(nameof(taskId))] public virtual Task? task { get; set; }

        [Required] public Guid tagId { get; set; }

        [ForeignKey(nameof(tagId))] public virtual Tag? tag { get; set; }
    }
}