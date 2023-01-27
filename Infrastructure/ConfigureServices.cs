using Application.Zadanie.Interface;
using Infrastructure.Adapters;
using Infrastructure.Services.CsvFileService;
using Infrastructure.Services.CsvFileService.Interface;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        //TODO wymienic reczne wstrzykiwanie na "konwencje zamiast konfiguracji"
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddSingleton<IZadanieLoad, CsvFileServiceToZadanieLoadAdapter>();
        services.AddSingleton<IZadanieSave, CsvFileServiceToZadanieSaveAdapter>();
        services.AddSingleton<IFileLoad, FileLoad>();
        services.AddSingleton<IFileSave, FileSave>();

        return services;
    }
}
