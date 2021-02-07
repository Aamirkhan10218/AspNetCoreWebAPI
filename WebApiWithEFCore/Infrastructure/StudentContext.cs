using Microsoft.EntityFrameworkCore;
using WebApiWithEFCore.Model;

namespace WebApiWithEFCore.Infrastructure
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
