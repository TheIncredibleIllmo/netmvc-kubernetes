using Microsoft.EntityFrameworkCore;
using mvcprototype.Models;

public class CoursesContext : DbContext
{
    public CoursesContext(DbContextOptions<CoursesContext> options) : base(options)
    {

    }

    public DbSet<Instructor> Instructors { get; set; }
}