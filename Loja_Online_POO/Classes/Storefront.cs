using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO.Classes
{
    internal class Storefront : Categoria //storefront herda a categoria
    {
        //atributos storefront

        public string cliente {  get; set; }
        public int vendas { get; set; }
        public string Searchbar { get; set; }


        //classe construtor

        public Storefront(int ID, string nome, int preço, string descrição, int garantia, string imagem, string Cliente, int Vendas, string Search) : base(ID, nome, preço, descrição, garantia, imagem)
        {
            cliente = Cliente;
            vendas = Vendas;
            Searchbar = Search;
        }
    }
}
