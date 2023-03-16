using Application.Services;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistance;
using Persistance.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application;

public static class StartupSetup
{
    public static void AddPersistenceContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext(connectionString);
    }

    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
    }

}
