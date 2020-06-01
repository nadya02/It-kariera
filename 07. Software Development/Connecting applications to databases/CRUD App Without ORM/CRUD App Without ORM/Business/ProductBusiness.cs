using CRUD_App_Without_ORM.Common;
using CRUD_App_Without_ORM.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_App_Without_ORM.Business
{
    //бизнес логиката на приложението
    class ProductBusiness//?? да питам какво прави класа
    {
        private ProductData manager = new ProductData();

        public List<Product> GetAll()
        {
            return manager.GetAll();
        }

        public Product Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Product product)
        {
            manager.Add(product);
        }

        public void Update(Product product)
        {
            manager.Update(product);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}
