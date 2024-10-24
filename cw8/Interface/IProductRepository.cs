using cw8.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  cw8.Entitys;
using cw8.Enums;

namespace cw8.Interface
{
    public interface IProductRepository
    {
        public void AddProduct(Product product);
        public void RemoveProduct(int id);
        public void UpdateProduct(int id, Product product1);
        public Product GetProduct(int id);
        public List<Product> GetAllProducts();
        public int GetId();
    }
}
