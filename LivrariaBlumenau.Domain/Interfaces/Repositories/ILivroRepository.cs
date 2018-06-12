using LivrariaBlumenau.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Domain.Interfaces.Repositories
{
	public interface ILivroRepository : IRepository<Livro>
	{
		IEnumerable<Livro> BuscarPorNome(string nome);
	}
}
