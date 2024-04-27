using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductBusiness
    {
        public List<Product> Get()
        {
            ProductData productData = new ProductData();
            var products = productData.Get();
            return products;
        }
        public List<Product> GetbyName(string name)
        {
            ProductData productData = new ProductData();
            var products = productData.Get();
            var result = products.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            return result;
        }
    }
}
