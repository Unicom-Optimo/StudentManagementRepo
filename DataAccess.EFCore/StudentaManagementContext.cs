using DataAccess.EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore
{
    public class StudentaManagementContext : DbContext

    {
        public StudentaManagementContext(DbContextOptions<StudentaManagementContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Management> Managements { get; set; }

    }
}
