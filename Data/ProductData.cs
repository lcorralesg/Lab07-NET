using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data
{
    public class ProductData
    {
        public List<Product> Get()
        {
            List <Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(DB.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetProducts", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(reader["product_id"]);
                    product.Name = reader["name"].ToString();
                    product.Price = Convert.ToDecimal(reader["price"]);
                    product.Stock = Convert.ToInt32(reader["stock"]);
                    product.Active = Convert.ToBoolean(reader["active"]);
                    products.Add(product);
                }
            }
            return products;
        }
        public void Insert()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
