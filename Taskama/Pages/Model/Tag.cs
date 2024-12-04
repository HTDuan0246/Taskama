using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taskama.Pages.Model
{
    public class Tag
    {
        [Key] public Guid taskId { get; set; }

        [Required][StringLength(50)] public string taskName { get; set; }

        [StringLength(7)] // Mã màu hex
        public string color { get; set; }

        public virtual ICollection<TaskTag>? taskTags { get; set; }
    }
}