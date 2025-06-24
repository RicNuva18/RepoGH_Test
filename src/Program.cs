using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

app.MapGet("/hello", (ILogger<Program> logger) =>
{
    logger.LogInformation("Se invocó /hello");
    return Results.Text("Hola mundo!","text/plain");
});

app.Run();

public partial class Program { }
