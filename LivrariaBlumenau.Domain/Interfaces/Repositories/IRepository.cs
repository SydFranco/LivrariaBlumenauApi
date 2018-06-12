using System;
using System.Collections;
using System.Collections.Generic;

namespace LivrariaBlumenau.Domain.Interfaces.Repositories
{
	public interface IRepository<TEntity> where TEntity : class
	{
		void Add(TEntity obj);
		TEntity GetById(int id);
		IEnumerable<TEntity> GetAll();
		void Update(TEntity obj);
		void Remove(TEntity obj);
		void Dispose();
	}
}
