﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
namespace ProductTrackingProject.Application;
public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(opt =>{opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); });
        return services;
    }
}