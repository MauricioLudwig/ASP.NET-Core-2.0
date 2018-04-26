using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Lecture2.Data;
using Lecture2.Entities;
using Lecture2.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lecture2.Controllers
{
    public class HomeController : Controller
    {

        private BooksDbContext context;
        private IMapper mapper;

        public HomeController(BooksDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewBookVM model)
        {

            if (!ModelState.IsValid)
                View(model);

            context.Books.Add(mapper.Map<Book>(model));
            context.SaveChanges();

            return RedirectToAction(nameof(HomeController.Index));
        }

        public IActionResult Edit()
        {
            return Ok();
        }

        public IActionResult Delete()
        {
            return Ok();
        }

    }
}
