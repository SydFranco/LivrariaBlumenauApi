using AutoMapper;
using LivrariaBlumenau.Application.Interface;
using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Presentation.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivrariaBlumenau.Presentation.MVC.Controllers
{
    public class LivrosController : Controller
    {
		private readonly ILivroAppService _livroApp;

		public LivrosController(ILivroAppService livroApp)
		{
			_livroApp = livroApp;
		}

		// GET: Livros
		public ActionResult Index()
        {
			var livroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroApp.GetAll());
			return View(livroViewModel);
		}

        // GET: Livros/Details/5
        public ActionResult Details(int id)
        {
			var livro = _livroApp.GetById(id);
			var livroModel = Mapper.Map<Livro, LivroViewModel>(livro);
			return View(livroModel);
		}

        // GET: Livros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(LivroViewModel livro)
        {
			try
			{
				if (ModelState.IsValid)
				{
					var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
					_livroApp.Add(livroDomain);

					return RedirectToAction("Index");
				}

				return View(livro);
			}
			catch
			{
				return View();
			}
		}

        // GET: Livros/Edit/5
        public ActionResult Edit(int id)
        {
			var livro = _livroApp.GetById(id);
			var livroModel = Mapper.Map<Livro, LivroViewModel>(livro);

			return View(livroModel);
		}

        // POST: Livros/Edit/5
        [HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(LivroViewModel livro)
        {
			try
			{
				var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
				_livroApp.Update(livroDomain);

				return RedirectToAction("Index");
			}
			catch
			{
				return View(livro);
			}
		}

        // GET: Livros/Delete/5
        public ActionResult Delete(int id)
        {
			var livro = _livroApp.GetById(id);
			var livroModel = Mapper.Map<Livro, LivroViewModel>(livro);

			return View(livroModel);
		}

		// POST: Livros/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
        {
			try
			{
				var livro = _livroApp.GetById(id);
                _livroApp.Remove(livro);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
    }
}
