using CRUD_With_ORM.Data;
using CRUD_With_ORM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD_With_ORM.Business
{
    class ProductBusiness
    {
        private ProductContext productContext;

        public List<Product> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.ToList();
                //productContext - база данни
                //Product = таблицата
            }
        }

        public Product Get(int id)
        {
            using (productContext = new ProductContext())//productContext е като connection в задачите дето решавахме в началото
            {
                return productContext.Products.Find(id);
            }
        }

        public void Add(Product product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Products.Add(product);
                productContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (productContext = new ProductContext())
            {
                var item = productContext.Products.Find(product.Id);
                if(item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    //Entry - насочва в таблицата в реда където е продукта
                    productContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var item = productContext.Products.Find(id);
                if (item != null)
                {
                    productContext.Products.Remove(item);
                    productContext.SaveChanges();
                }
            }
        }
    }
}
