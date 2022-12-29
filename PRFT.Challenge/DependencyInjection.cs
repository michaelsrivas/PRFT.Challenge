using Microsoft.AspNetCore.Mvc.Infrastructure;
using PRFT.Challenge.Api.Common.Errors;
using PRFT.Challenge.Api.Common.Mapping;

namespace PRFT.Challenge.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, PRFTProblemDetailsFactory>();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddMappings();
        return services;
    }
}
