using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Domain.Interfaces.Repositories;
using LivrariaBlumenau.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LivrariaBlumenau.Infrastructure.Data.Repositories
{
	public class LivroRepository : Repository<Livro>, ILivroRepository
	{
		//public LivroRepository(LivrariaBlumenauContext db) : base(db)
		//{
		//	Db = db;
		//}

		public IEnumerable<Livro> BuscarPorNome(string nome)
		{
			return Db.Livros.Where(x => x.Nome.Contains(nome));
		}
	}
}
