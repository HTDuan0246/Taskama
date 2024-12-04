using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taskama.Pages.Model
{
    public class Task
    {
        [Key] public Guid taskId { get; set; }

        [Required] public string title { get; set; }

        public string description { get; set; }

        [Required] public TaskStatus status { get; set; }

        [Required] public DateTime? createdAt { get; set; }

        public DateTime? dueDate { get; set; }

        [Required] public Priority priority { get; set; }

        // Foreign Keys
        public Guid? assignedToId { get; set; }

        [ForeignKey(nameof(assignedToId))] public virtual User? assignedTo { get; set; }

        public Guid? projectId { get; set; }

        [ForeignKey(nameof(projectId))] public virtual Project? project { get; set; }

        // Navigation Properties
        public virtual ICollection<Comment>? Comments { get; set; }

        public virtual ICollection<TaskTag>? TaskTags { get; set; }
    }
}