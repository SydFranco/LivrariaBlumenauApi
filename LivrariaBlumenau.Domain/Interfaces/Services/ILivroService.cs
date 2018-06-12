using LivrariaBlumenau.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Domain.Interfaces.Services
{
	public interface ILivroService : IService<Livro>
	{
		IEnumerable<Livro> BuscarPorNome(string nome);
	}
}
