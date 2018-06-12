using AutoMapper;
using LivrariaBlumenau.Domain.Entities;
using LivrariaBlumenau.Infrastructure.Data.Repositories;
using LivrariaBlumenau.Presentation.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LivrariaBlumenau.Presentation.MVC.Controllers
{
    public class TesteController : Controller
    {
		private readonly LivroRepository _livroRepository = new LivroRepository();
        // GET: Teste
        public ActionResult Index()
        {
			var livroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroRepository.GetAll());
            return View(livroViewModel);
        }

        // GET: Teste/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teste/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teste/Create
        [HttpPost]
        public ActionResult Create(LivroViewModel livro)
        {
            try
            {
				if (ModelState.IsValid)
				{
					var livroDomain = Mapper.Map<LivroViewModel, Livro>(livro);
					_livroRepository.Add(livroDomain);
					return RedirectToAction("Index");
				}
				else
					return View(livro);
            }
            catch
            {
                return View();
            }
        }

        // GET: Teste/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teste/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Teste/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teste/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
