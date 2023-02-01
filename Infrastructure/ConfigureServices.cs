using Application.JobService.Interface;
using Infrastructure.Adapters;
using Infrastructure.Services.CsvFileService;
using Infrastructure.Services.CsvFileService.Interface;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        //TODO wymienic reczne wstrzykiwanie na "konwencje zamiast konfiguracji"
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddSingleton<IJobApplyLoad, CsvFileServiceToJobApplyLoad>();
        services.AddSingleton<IJobApplySave, CsvFileServiceToJobApplySave>();
        services.AddSingleton<IFileLoad, FileLoad>();
        services.AddSingleton<IFileSave, FileSave>();

        return services;
    }
}
