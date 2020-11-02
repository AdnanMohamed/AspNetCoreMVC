using Adnan.Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adnan.Bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> getAllBooks()
        {
            return dataSource();
        }

        public BookModel getBookModel(int id)
        {
            return dataSource().Where(book => book.Id == id).FirstOrDefault();
        }

        public List<BookModel> searchBook(string title, string author)
        {
            return dataSource().Where(book => book.Title.Contains(title) || book.Author.Contains(author)).ToList();
        }

        private List<BookModel> dataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Author = "Adnan Mohamed", Title="How to Live"},
                new BookModel(){Id = 2, Author = "Ali Fahad", Title="The Rangers"},
                new BookModel(){Id = 3, Author = "Ali Yaseen", Title="C++ For Children"},
                new BookModel(){Id = 4, Author = "Adnan Mohamed", Title="Quantum Mechanics"},
                new BookModel(){Id = 5, Author = "Mohamed Jawad", Title="R for Machine Learning"}
            };
        }
    }
}
