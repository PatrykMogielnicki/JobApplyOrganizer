using Application.Zadanie;
using Application.Zadanie.Interface;
using Application.Zadanie.Mapping;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services)
    {
        //TODO wymienic reczne wstrzykiwanie na "konwencje zamiast konfiguracji"
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddSingleton<IZadanieParser, ZadanieParser>();
        services.AddSingleton<IZadanieFactory, ZadanieFactory>();
        services.AddScoped<IZadanieRepository, ZadanieRepository>();
        services.AddScoped<IZadanieService, ZadanieService>();
        
        return services;
    }
}
