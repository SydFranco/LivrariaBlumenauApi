using LivrariaBlumenau.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace LivrariaBlumenau.Infrastructure.Data.EntityConfig
{
	public class LivroConfiguration : EntityTypeConfiguration<Livro>
	{
		public LivroConfiguration()
		{
			HasKey(x => x.Id);
			Property(x => x.Nome)
				.IsRequired();
			Property(x => x.Autor)
				.IsRequired()
				.HasMaxLength(150);
			Property(x => x.Editora)
				.IsRequired()
				.HasMaxLength(150);
			Property(x => x.Ano)
				.IsOptional();
			Property(x => x.ISBN)
				.IsRequired();
		}
	}
}
