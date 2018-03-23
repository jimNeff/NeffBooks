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
            throw new NotImplementedException();
        }

        public BOOK GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BOOK> List()
        {
            return sqlContext.Books;
        }

        public bool SaveChanges(BOOK item)
        {
            throw new NotImplementedException();
        }
    }
}
