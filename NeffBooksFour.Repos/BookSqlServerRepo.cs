using Microsoft.EntityFrameworkCore;
using NeffBooksFour.Data;
using NeffBooksFour.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeffBooksFour.Repos
{
    public class BookSqlServerRepo : IRepo<BOOK>
    {
        private NeffBooksSqlServerContext sqlContext;
        public BookSqlServerRepo(NeffBooksSqlServerContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }
        public bool Create(BOOK item)
        {
            try
            {
                sqlContext.Books.Add(item);
                sqlContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
            
        }

        public bool Delete(int id)
        {
            var book = this.sqlContext.Books
                .Where(bk => bk.ID == id)
                .FirstOrDefault();

            if (book != null)
            {
                this.sqlContext.Entry<BOOK>(book).State = EntityState.Deleted;
                this.sqlContext.SaveChanges();
            }

            return true;
        }

        public BOOK GetById(int id)
        {
            return this.sqlContext.Books
                .Where(bk => bk.ID == id)
                .FirstOrDefault();
        }

        public IQueryable<BOOK> List()
        {
            return sqlContext.Books;
        }

        public bool SaveChanges(BOOK item)
        {
            try
            {
                this.sqlContext.Entry<BOOK>(item).State = EntityState.Modified;
                this.sqlContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
