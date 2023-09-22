using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductsCRUD.Data.Context;
using ProductsCRUD.Data.Repository;
using ProductsCRUD.Interfaces.Repository;
using ProductsCRUD.Interfaces.Services;
using ProductsCRUD.Services;

namespace ProductsCRUD.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<ApplicationDbContext>(opt => 
            opt.UseSqlServer("Server=DESKTOP-5AH2627;DataBase=ProductsDataBase;Trusted_Connection =True; Encrypt=False;"));

            return services;
        }
    }
}
