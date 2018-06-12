using LivrariaBlumenau.Domain.Interfaces.Repositories;
using LivrariaBlumenau.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaBlumenau.Infrastructure.Data.Repositories
{
	public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
	{
		protected LivrariaBlumenauContext Db = new LivrariaBlumenauContext();

		//public Repository(LivrariaBlumenauContext db)
		//{
		//	Db = db;
		//}

		public void Add(TEntity obj)
		{
			Db.Set<TEntity>().Add(obj);
			Db.SaveChanges();
		}

		public void Dispose()
		{
            Db.Dispose();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return Db.Set<TEntity>().ToList();
		}

		public TEntity GetById(int id)
		{
			return Db.Set<TEntity>().Find(id);
		}

		public void Remove(TEntity obj)
		{
			Db.Set<TEntity>().Remove(obj);
			Db.SaveChanges();
		}

		public void Update(TEntity obj)
		{
			Db.Entry(obj).State = EntityState.Modified;
			Db.SaveChanges();
		}
	}
}
