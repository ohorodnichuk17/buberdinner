using System.Reflection;
using BuberDinner.Application.Common.Behaviors;
using MediatR;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application;

public static class DependencyInjectionRegister
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjectionRegister).Assembly);

        services.AddScoped(typeof(IPipelineBehavior<,>),
            typeof(ValidationBehavior<, >));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}