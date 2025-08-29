using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductApi.Models;
 
 

namespace ProductApi.Data
{
    public class ApplicationDbContext : DbContext
    { 
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
