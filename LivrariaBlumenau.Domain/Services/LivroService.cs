using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Domain.Interfaces.Repositories;
using LivrariaBlumenau.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Domain.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public IEnumerable<Livro> BuscarPorNome(string nome)
        {
            return _livroRepository.BuscarPorNome(nome);
        }
    }
}
