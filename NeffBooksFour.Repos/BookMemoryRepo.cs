using NeffBooksFour.Data;
using NeffBooksFour.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeffBooksFour.Repos
{
    public class BookMemoryRepo : IRepo<BOOK>
    {
        private List<BOOK> books = new List<BOOK>();
        public bool Create(BOOK item)
        {
            try
            {
                this.books.Add(item);
                return true; 
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                var book = this.books
                    .Where(bk => bk.ID == id)
                    .FirstOrDefault();

                this.books.Remove(book);
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public BOOK GetById(int id)
        {
            return this.books.Where(bk => bk.ID == id)
                .FirstOrDefault();
        }

        public IQueryable<BOOK> List()
        {
            return this.books.AsQueryable();
        }

        public bool SaveChanges(BOOK item)
        {
            try
            {
                Delete(item.ID);
                Create(item);
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }
}
