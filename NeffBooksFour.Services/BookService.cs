using NeffBooksFour.Data;
using NeffBooksFour.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace NeffBooksFour.Services
{
    public class BookService : IBookService
    {
        private IRepo<BOOK> bookRepo;
        public BookService(IRepo<BOOK> bookRepo)
        {
            this.bookRepo = bookRepo;
        }
        public Task<bool> AddBook(BOOK book)
        {
            return Task.Run(() => this.bookRepo.Create(book));
        }

        public Task<List<BOOK>> GetAllBooks()
        {
            return Task.Run(() => this.bookRepo.List().ToList());
        }
    }
}
