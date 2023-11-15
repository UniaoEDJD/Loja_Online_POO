using System;
using System.Collections.Generic;
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
        public int Price { get; set; }
        public string Description { get; set; }
        public int Warranty { get; set; }
        public int ProductCatID
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }
        public byte[] Image { get; set; }

        //construtores da classe

        public Product(int ID, string nome, int produto, string pname, int preço, string descrição, int garantia, int prodCatID) : base(ID, nome)
        {
            productID = produto;
            productName = pname;
            Price = preço;
            Description = descrição;
            Warranty = garantia;
            ProductCatID = prodCatID;
        }

        
    }
}
