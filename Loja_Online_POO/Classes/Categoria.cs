using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Online_POO.Classes
{
    public class Categoria //classe principal
    {
        //atributos classe

        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
        
        //construtores classe

        public Categoria()
        {
            Products = new List<Product>();
        }

        List<Categoria> categorias;

    }
}
