using AutoMapper;
using LivrariaBlumenau.App.WebApi.ViewModels;
using LivrariaBlumenau.Application.Interface;
using LivrariaBlumenau.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LivrariaBlumenau.App.WebApi.Controllers
{
	[RoutePrefix("api/v1")]
	//[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class LivrosController : ApiController
    {
        private readonly ILivroAppService _livroApp;

        public LivrosController(ILivroAppService livroApp)
        {
            _livroApp = livroApp;
        }

        [HttpGet]
		[Route("getLivros")]
		public IHttpActionResult GetLivros()
		{
			var livros = _livroApp.GetAll().ToList();
			return Ok(livros);
		}

        [HttpPost]
		[Route("create")]
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public IHttpActionResult Create([FromBody]Livro livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _livroApp.Add(livro);

                    return Ok(livro);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(ex.InnerException);
            }
		}

		[HttpPost]
		[Route("update")]
		public IHttpActionResult Update([FromBody]Livro livro)
		{
			try
			{
				if (ModelState.IsValid)
				{
					_livroApp.Update(livro);

					return Ok(livro);
				}

				return Ok(livro);
			}
			catch (Exception ex)
			{
				return Ok(ex.InnerException);
			}
		}

		[HttpPost]
        [Route("delete/{id}")]
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public IHttpActionResult Delete(int id)
        {
            var livro = _livroApp.GetById(id);
            if (livro == null)
            {
                return NotFound();
            }

            _livroApp.Remove(livro);
            return Ok("Livro deletado");
        }
	}
}
