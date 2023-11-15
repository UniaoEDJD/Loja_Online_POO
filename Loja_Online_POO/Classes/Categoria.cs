using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO.Classes
{
    internal class Categoria
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
        
        public Categoria()
        {
            Products = new List<Product>();
        }
    }
}
