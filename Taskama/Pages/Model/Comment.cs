using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taskama.Pages.Model
{
    public class Comment
    {
        [Key] public Guid commentId { get; set; }

        [Required][StringLength(1000)] public string content { get; set; }

        [Required] public DateTime createdAt { get; set; }

        // Foreign Keys
        [Required] public Guid taskId { get; set; }

        [ForeignKey(nameof(taskId))] public virtual Task? task { get; set; }

        [Required] public Guid userId { get; set; }

        [ForeignKey(nameof(userId))] public virtual User? user { get; set; }
    }
}