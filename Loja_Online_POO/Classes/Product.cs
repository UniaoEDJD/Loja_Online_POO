using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO.Classes
{
    internal class Product : Categoria //produto herda a categoria
    {
        //atributoproduto

        public string marca {  get; set; }
        public int stock { get; set; }

        //classe construtor

        public Product(int ID, string nome, int preço, string descrição, int garantia, string imagem, string Marca, int Stock) : base(ID, nome, preço, descrição, garantia, imagem)
        {
            marca = Marca;
            stock = Stock;
        }
    }
}
