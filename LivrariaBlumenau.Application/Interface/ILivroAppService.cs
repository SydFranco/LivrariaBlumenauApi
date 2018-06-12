using LivrariaBlumenau.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Application.Interface
{
    public interface ILivroAppService : IAppService<Livro>
    {
        IEnumerable<Livro> BuscarPorNome(string nome);
    }
}
