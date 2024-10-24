using cw8.Entitys;
using cw8.Enums;
using cw8.Interface;
using cw8.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8.Services
{
    public class ProductService
    {
        IProductRepository productrep;
        public ProductService()
        {
            productrep = new ProductRepository();
        }
        public int index()
        {
          return productrep.GetId();
            
        }
        public void AddProduct(Product product)
        {
            productrep.AddProduct(product);

        }
        public void Remove(Product product)
        {
            productrep.RemoveProduct(product.Id);
        }
        public void Update(Product product)
        {
            productrep.UpdateProduct(product.Id, product);
        }
        public Product Get(Product product)
        {
          return  productrep.GetProduct(product.Id);
        }
        public List<Product> GetAll()
        {
           return productrep.GetAllProducts();
        }
    }
}
