using cw8.Entitys;
using cw8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8.DataBase
{
    public static class FileProduct
    {
        
           
           
            public static List<Product> productlist = new List<Product>();

            static FileProduct()
            {
               
                productlist = new List<Product>
                {
                    new Product(){Id=0,NameProduct="Iphone 16 pro max",Price=150000000,category=EnumCategory.mobile},
                    new Product(){Id=1,NameProduct="Tv Sumsung 65 inch",Price=50000000,category=EnumCategory.tv},
                    new Product(){Id=2,NameProduct="Refrigerator LG side by side",Price=70000000,category=EnumCategory.refrigerator},
                    new Product(){Id=3,NameProduct="Laundry bush 7 kg",Price=65000000,category=EnumCategory.laundry},
                    new Product(){Id=4,NameProduct="Dishwasher bush seri 7",Price=55000000,category=EnumCategory.dishwasher},
                };

            }
        }
    }

