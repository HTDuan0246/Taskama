using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessObject.Model
{
    [Table("users", Schema = "dbo")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required]
        [JsonIgnore]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        [InverseProperty("Users")]
        public virtual ICollection<Role> Roles { get; set; } = new HashSet<Role>();

        [InverseProperty("Users")]
        public virtual ICollection<Program> Programs { get; set; } = new List<Program>();

        public User()
        { }

        public User(string name, string username, string email, string password)
        {
            Name = name;
            Username = username;
            Email = email;
            Password = password;
        }
    }
}