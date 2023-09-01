using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksAppNet.Models;
using BooksAppNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksAppNet.Controllers.Books
{
    public class BooksController : Controller
    {
        private BooksService booksService;

        public async Task<IActionResult> Index()
        {
            this.booksService = new BooksService();

            await this.booksService.GetBookList();

            return View(booksService.Books);
        }
    }
}