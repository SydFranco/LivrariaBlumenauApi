using AutoMapper;
using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Presentation.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaBlumenau.Presentation.MVC.AutoMapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public ViewModelToDomainMappingProfile()
		{
			CreateMap<Livro, LivroViewModel>();
		}
	}
}