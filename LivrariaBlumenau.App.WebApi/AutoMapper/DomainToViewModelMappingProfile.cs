using AutoMapper;
using LivrariaBlumenau.App.WebApi.ViewModels;
using LivrariaBlumenau.Domain.Entities;

namespace LivrariaBlumenau.App.WebApi.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<LivroViewModel, Livro>();
        }
    }
}