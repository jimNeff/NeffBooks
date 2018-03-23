using Microsoft.AspNetCore.Mvc;
using NeffBooksFour.Data;
using NeffBooksFour.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeffBooksFour.Controllers
{
    public class HomeController : Controller
    {
        private IBookService bookService;

        public HomeController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Neff Books";
            return View(await bookService.GetAllBooks());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "Add Book";
            return View(new BOOK());
        }

        [HttpPost]
        public async Task<IActionResult> Add(BOOK book)
        {
            if (ModelState.IsValid)
                await bookService.AddBook(book);

            return RedirectToAction("Index");
        }

    }
}
