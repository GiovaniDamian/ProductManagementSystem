using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProductManagementSystem.Domain.Repositories;
using ProductManagementSystem.Domain.Services;
using ProductManagementSystem.Shared.DTOs;
using ProductManagementSystem.Infra.IoC.AutoMapper;

namespace ProductManagementSystem.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraIoC(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ProdutoService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            return services;
        }
    }

}
