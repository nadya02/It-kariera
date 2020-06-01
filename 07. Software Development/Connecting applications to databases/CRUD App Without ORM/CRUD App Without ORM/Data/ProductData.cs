
using CRUD_App_Without_ORM.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CRUD_App_Without_ORM.Data
{
    //необходимите SQL команди, за да се извършват CRUD операции
    public class ProductData
    {
        //директно комуникира с базата данни
        //ще за дава заявки от Db server-a и ще връща
        public List<Product> GetAll()//връща списък от всички продукти
        {
            var productList = new List<Product>();

            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                string query = "select *from product";
                SqlCommand command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())//на всяка итерация връща по 1ред от таблицата
                    {
                        var product = new Product(
                            reader.GetInt32(0),  //парсва първата колонка
                            reader.GetString(1),
                            reader.GetDecimal(2),
                            reader.GetInt32(3)
                            );
                        productList.Add(product);
                    }
                }
            }

            return productList;
        }

        public Product Get(int id)//по дадено id на продукт получаваме информация за него
        {
            Product product = null;

            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                string query = "select *from product where Id = @id";//@ - предпазва от инжектиране
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())//ако в базата данни няма продукт с желаното id -> продуктът ще остане със стойност null 
                    {
                         product = new Product(
                            reader.GetInt32(0),  //парсва първата колонка
                            reader.GetString(1),
                            reader.GetDecimal(2),
                            reader.GetInt32(3)
                            );                     
                    }
                }
            }

            return product;
        }

        public void Add(Product product)
        {
            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                string query = "insert into product (Name, Price, Stock) values (@name, @price, @stock);";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("stock", product.Stock);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Product product)
        {
            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                string query = "update product set NAme = @name, Price = @price, Stock = @stock where Id = @id;";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", product.Id);
                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("stock", product.Stock);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = DataBase.GetConnection())
            {
                connection.Open();
                string query = "delete product where Id = @id;";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("id", id);      

                command.ExecuteNonQuery();
            }
        }
    }
}
