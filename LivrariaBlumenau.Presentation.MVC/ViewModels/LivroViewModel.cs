using System;
using System.ComponentModel.DataAnnotations;

namespace LivrariaBlumenau.Presentation.MVC.ViewModels
{
	public class LivroViewModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage ="Informe o nome.")]
		public string Nome { get; set; }
		[Required(ErrorMessage = "Informe a descrição.")]
		[Display(Name ="Descrição")]
		public string Descricao { get; set; }
		[Required(ErrorMessage = "Informe o autor.")]
		public string Autor { get; set; }
		[Required(ErrorMessage = "Informe a editora.")]
		public string Editora { get; set; }
		[Required(ErrorMessage = "Informe o ano.")]
		public int Ano { get; set; }
		[Required(ErrorMessage = "Informe o ISBN.")]
		public string ISBN { get; set; }
		[ScaffoldColumn(false)]
		public DateTime DataCadastro { get; set; }
		public DateTime? DataVenda { get; set; }
	}
}