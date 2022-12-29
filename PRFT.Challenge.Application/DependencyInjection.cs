using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PRFT.Challenge.Application.Common.Behaviors;
using System.Reflection;

namespace PRFT.Challenge.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));        
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}
