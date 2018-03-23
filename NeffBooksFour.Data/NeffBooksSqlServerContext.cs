using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeffBooksFour.Data
{
    public class NeffBooksSqlServerContext : DbContext
    {
        public DbSet<BOOK> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9PC10QF\SQLEXPRESS; Database=neff_books; Integrated Security=True;");
        }
    }
}
