using LivrariaBlumenau.Application.Interface;
using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace LivrariaBlumenau.Application.Service
{
    public class LivroAppService : AppService<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService) : base(livroService)
        {
            _livroService = livroService;
        }

        public IEnumerable<Livro> BuscarPorNome(string nome)
        {
            return _livroService.BuscarPorNome(nome);
        }
    }
}
