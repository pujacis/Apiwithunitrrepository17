using DataAccessLayer.DataContext;
using DataAccessLayer.Repository;
using InterfaceEntity.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataAccessLayerContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("conn"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ITaskPersonRepository, TaskPersonRepository>();

            return services;
        }
    }
}
