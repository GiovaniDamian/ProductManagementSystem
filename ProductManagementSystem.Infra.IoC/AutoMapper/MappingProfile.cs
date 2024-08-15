using AutoMapper;
using ProductManagementSystem.Domain.Entities;
using ProductManagementSystem.Shared.DTOs;

namespace ProductManagementSystem.Infra.IoC.AutoMapper
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Produto, ProdutoDTO>();
            CreateMap<Variacao, VariacaoDTO>();
        }
    }
}