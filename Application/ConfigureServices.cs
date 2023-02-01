using Application.JobService;
using Application.JobService.Interface;
using Application.JobService.Mapping;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class ConfigureServices
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services)
    {
        //TODO wymienic reczne wstrzykiwanie na "konwencje zamiast konfiguracji"
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddSingleton<IJobApplyParser, JobApplyParser>();
        services.AddSingleton<IJobApplyFactory, JobApplyFactory>();
        services.AddScoped<IJobApplyRepository, JobApplyRepository>();
        services.AddScoped<IJobApplyService, JobApplyService>();

        return services;
    }
}
