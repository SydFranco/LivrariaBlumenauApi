using System;

namespace LivrariaBlumenau.Domain.Entities
{
	public class Livro
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string Autor { get; set; }
		public string Editora { get; set; }
		public int Ano { get; set; }
		public string ISBN { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataVenda { get; set; }
	}
}
