using ETicaret.Application.Repositories.CustomerRepositories;
using ETicaret.Application.Repositories.OrderRepositories;
using ETicaret.Application.Repositories.ProductRepositories;
using ETicaret.Persistence.Contexts;
using ETicaret.Persistence.Repositories.CustomerRepositories;
using ETicaret.Persistence.Repositories.OrderRepositories;
using ETicaret.Persistence.Repositories.ProductRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services) 
        {
            services.AddDbContext<EticaretDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            //Repositories
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
                     
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
                     
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
