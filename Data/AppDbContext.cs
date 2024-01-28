using Microsoft.EntityFrameworkCore;
using System.Xml;
using VpAssignment2.Models;

namespace VpAssignment2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define your entity DbSet properties here
        public DbSet<StudentModel> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the table name explicitly using Fluent API
            modelBuilder.Entity<StudentModel>().ToTable("student_model1");
        }

    }
}
