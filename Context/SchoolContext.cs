using CodeFirstEFCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEFCore.Context
{
    public class SchoolContext : IdentityDbContext
    {
        public SchoolContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentFailed> StudentFaileds { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API relationship StudentFailed-Student
            modelBuilder.Entity<StudentFailed>()
            .HasOne(sf => sf.Student)
            .WithOne(s => s.StudentFailed)
            .HasForeignKey<StudentFailed>(sf => sf.StudentId)
            .IsRequired();

            // Fluent API relationship Class-Teacher
            modelBuilder.Entity<Class>()
            .HasOne(t => t.Teacher)
            .WithOne(c => c.Class)
            .HasForeignKey<Teacher>(t => t.ClassId)
            .IsRequired();

            // Fluent API relationship Class-Student
            modelBuilder.Entity<Class>()
            .HasMany(c => c.Students)
            .WithOne(st => st.Class)
            .HasForeignKey(st => st.ClassId)
            .IsRequired();

            // Fluent API relationship Student-Course
            modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
            .HasOne(s => s.Student)
            .WithMany(sc => sc.StudentCourses)
            .HasForeignKey(s => s.StudentId)
            .IsRequired();

            modelBuilder.Entity<StudentCourse>()
            .HasOne(c => c.Course)
            .WithMany(sc => sc.StudentCourses)
            .HasForeignKey(c => c.CourseId)
            .IsRequired();
        }

    }
}