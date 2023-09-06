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
        private readonly IBooksService booksService;

        public BooksController(IBooksService booksService)
        {
            this.booksService = booksService;
        }

        public async Task<IActionResult> Index()
        {

            await this.booksService.GetBookList();

            return View(booksService.GetBooks());
        }

        public IActionResult AddBook()
        {
            BookModel book = new BookModel();

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> ProcessAddBook(BookModel book)
        {
            if (book != null)
            {
                bool status = await booksService.AddBook(book);
            }

            await booksService.GetBookList();

            return View("Index", booksService.GetBooks());
        }
    }
}