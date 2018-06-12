using AutoMapper;
using LivrariaBlumenau.App.WebApi.ViewModels;
using LivrariaBlumenau.Domain.Entities;

namespace LivrariaBlumenau.App.WebApi.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Livro, LivroViewModel>();
        }
    }
}