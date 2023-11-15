using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO.Classes
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; } 
        public int Price { get; set; }
        public string Description { get; set; }
        public int Warranty { get; set; }
        public int CategoryID { get; set; }
        public byte[] Image { get; set; }
    }
}
