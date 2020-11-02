using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adnan.Bookstore.Models;
using Adnan.Bookstore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Adnan.Bookstore.Contollers
{
    public class BookController : Controller
    {

        private readonly BookRepository _bookRepository;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult getAllBooks()
        {
            return View();
        }

        public ViewResult getBook(int id)
        {
            return View();
        }

        public ViewResult searchBook(string title, string author)
        {
            return View();
        }
    }
}