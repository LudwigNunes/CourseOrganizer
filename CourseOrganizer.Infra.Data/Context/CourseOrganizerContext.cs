using System.Data.Entity;
using CourseOrganizer.Domain.Entities;

namespace CourseOrganizer.Infra.Data.Context
{
    public class CourseOrganizerContext : DbContext
    {
        public CourseOrganizerContext() : base("CourseOrganizer")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
