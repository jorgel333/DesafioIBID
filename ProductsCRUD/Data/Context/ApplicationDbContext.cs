using Microsoft.EntityFrameworkCore;
using ProductsCRUD.Entities;

namespace ProductsCRUD.Data.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ApplicationDbContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-5AH2627;DataBase=ProductsDataBase;Trusted_Connection =True; Encrypt=False;");
    }
}
