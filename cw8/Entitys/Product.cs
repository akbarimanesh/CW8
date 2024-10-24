using cw8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw8.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public EnumCategory category { get; set; }
    }
}
