using CRUD_With_ORM.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_With_ORM.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base()
        {

        }

        public DbSet<Product> Products { get; set; } //таблицата

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-1817IFM\SQLEXPRESS; Database = ProductDB; Integrated Security = true;");
           //прави връзката с батазата данни
        }
    }
}
