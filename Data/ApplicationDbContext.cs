using Appala_poo.com.Models;
using Microsoft.EntityFrameworkCore;

namespace Appala_poo.com.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }
        public DbSet<Brand> Brand { get; set; }
    }
}
