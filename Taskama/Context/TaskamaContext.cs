using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Taskama.Pages.Model;
using Task = Taskama.Pages.Model.Task;

namespace Taskama.Context
{
    public class TaskamaContext : DbContext
    {
        public TaskamaContext()
        {
        }

        // Constructor để dependency injection
        public TaskamaContext(DbContextOptions<TaskamaContext> options)
            : base(options)
        {
        }

        //Declare DbSet

        public DbSet<Task> tasks { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Tag> tags { get; set; }

        //Config to connect with database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true);
                IConfiguration configuration = builder.Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        //Config relationship
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjectMember>()
                .HasKey(pm => new { pm.projectId, pm.userId });

            modelBuilder.Entity<TaskTag>()
                .HasKey(tt => new { tt.tagId, tt.taskId });
        }
    }
}