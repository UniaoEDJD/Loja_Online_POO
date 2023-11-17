using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO.Classes
{
    public class Product : Categoria //produto herda a categoria
    {
        //atributos classe

        public int productID { get; set; }
        public string productName { get; set; } 
        public double Price { get; set; }
        public int Stock { get;set; }
        public string Description { get; set; }
        public int Warranty { get; set; }
        public string Marca { get; set; }
        public string ImagePath { get; set; }
        public int ProductCatID
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }       
        //construtores da classe

        public Product() : base()
        {

        }

        
    }
}
