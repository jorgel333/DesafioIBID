using Microsoft.EntityFrameworkCore;
using ProductsCRUD.Entities;

namespace ProductsCRUD.Data.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
    {
    }

    
}
