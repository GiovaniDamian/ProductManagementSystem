using Microsoft.EntityFrameworkCore;
using ProductManagementSystem.Domain.Repositories;
using ProductManagementSystem.Domain.Services;
using ProductManagementSystem.Infra.Data.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.MapGet("/endpoints", async context =>
{
    var endpointDataSource = context.RequestServices.GetRequiredService<EndpointDataSource>();
    var endpoints = endpointDataSource.Endpoints;

    await context.Response.WriteAsync("Registered Endpoints:\n");
    foreach (var endpoint in endpoints)
    {
        await context.Response.WriteAsync(endpoint.DisplayName + "\n");
    }
});

app.Run();
