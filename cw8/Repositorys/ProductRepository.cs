using cw8.DataBase;
using cw8.Entitys;
using cw8.Enums;
using cw8.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        string path = "E:/Databasse/product.json";
        public int GetId()
        {
            int id;
            if (File.Exists(path))
            {
                var data = File.ReadAllText(path);
                if (data == "")
                {
                    id = 0;
                    return id;
                }
                else
                {
                    var products = JsonConvert.DeserializeObject<List<Product>>(data);
                    id = products.Count();
                }


            }
            else
            {
                File.Create(path);
                id = 0;
                return id;
            } 
            return id;
        }
        public void AddProduct(Product product1)
        {
           
            var data = File.ReadAllText(path);
            var products = JsonConvert.DeserializeObject<List<Product>>(data);
            if(products is null)
            {
                products = new List<Product>();
            }
            products?.Add(product1);

            var result = JsonConvert.SerializeObject(products);
            File.WriteAllText(path, result + Environment.NewLine);
        
            
        }
        

        public List<Product> GetAllProducts()
        {
            var data = File.ReadAllText(path);
            var products = JsonConvert.DeserializeObject<List<Product>>(data);
            if (products is null)
            {
                products = new List<Product>();
            }
            return products;
        }

        public Product GetProduct(int id)
        {
            var data = File.ReadAllText(path);
            var products = JsonConvert.DeserializeObject<List<Product>>(data);
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void RemoveProduct(int id)
        {

            var data = File.ReadAllText(path);
            var products = JsonConvert.DeserializeObject<List<Product>>(data);
            var product= products.FirstOrDefault(p => p.Id == id);
            products.Remove(product);
            var result = JsonConvert.SerializeObject(products);
            File.WriteAllText( path,result);
            
        }

    

        public void UpdateProduct(int id,Product product1)
        {
            var data = File.ReadAllText(path);
            var products = JsonConvert.DeserializeObject<List<Product>>(data);
            var product = products.FirstOrDefault(p => p.Id == id);

            product.NameProduct = product1.NameProduct;
            product.category = product1.category;
            product.Price = product1.Price;
            var result = JsonConvert.SerializeObject(products);
            File.WriteAllText(path, result);

        }
    }
}
