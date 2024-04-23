using MalimoWeb.Models;
using MalimoWeb.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MalimoWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student>students { get; set; }
    }
}
