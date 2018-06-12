using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LivrariaBlumenau.Presentation.MVC.ViewModels;
using LivrariaBlumenau.Domain.Entities;

namespace LivrariaBlumenau.Presentation.MVC.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public DomainToViewModelMappingProfile()
		{
			CreateMap<LivroViewModel, Livro>();
		}
	}
}