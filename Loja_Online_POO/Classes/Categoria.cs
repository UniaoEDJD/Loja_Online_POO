using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO.Classes
{
    public class Categoria //classe principal
    {
        //atributos categoria

        public int productID { get; set; }
        public string productname { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Warranty { get; set; }
        public string Image {  get; set; }


        //classe construtor

        public Categoria (int ID, string nome, int preço, string descrição, int garantia, string imagem) 
        {
            productID = ID;
            productname = nome;
            Price = preço;
            Description = descrição;
            Warranty = garantia;
            Image = imagem;
        }



    }
}
