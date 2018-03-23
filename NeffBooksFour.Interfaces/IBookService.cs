using NeffBooksFour.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NeffBooksFour.Interfaces
{
    public interface IBookService
    {
        Task<List<BOOK>> GetAllBooks();
        Task<bool> AddBook(BOOK book);
    }
}
