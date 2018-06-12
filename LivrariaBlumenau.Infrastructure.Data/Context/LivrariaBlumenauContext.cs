using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Infrastructure.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace LivrariaBlumenau.Infrastructure.Data.Context
{
	public class LivrariaBlumenauContext : DbContext
	{
		public LivrariaBlumenauContext() : base("LivrariaBlumenau")
		{

		}

		public DbSet<Livro> Livros { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Configurations.Add(new LivroConfiguration());
		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataCadastro").CurrentValue = DateTime.Now;
				}
				else if (entry.State == EntityState.Modified)
				{
					entry.Property("DataCadastro").IsModified = false;
				}
			}
			return base.SaveChanges();
		}
	}
}
