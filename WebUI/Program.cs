using Application;
using Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddInfrastructureServices();
builder.Services.AddAplicationServices();

var app = builder.Build();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseHttpsRedirection();

app.UseStaticFiles();

//TODO move to config file
List<string> AdditionalDirectories = new List<string>()
{
    "JobOfferPhoto","CsvFiles"
};

AdditionalDirectories.ForEach(directory =>
{
    var path = Path.Combine(app.Environment.ContentRootPath, directory);
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }

    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(path),
        RequestPath = "/" + directory
    });
});

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
