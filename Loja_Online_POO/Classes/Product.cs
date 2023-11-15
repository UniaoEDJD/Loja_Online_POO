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
        //classes

        public string productID { get; set; }
        public string productName { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Warranty { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        public Product()
        {
            this.productID = "";
            this.productName = "";
            this.Price = "";
            this.Description = "";
            this.Warranty = "";
            this.Category = "";
            this.Image = "";
        }

        public Product(string ID, string name, string preço, string descriçao, string garantia, string categoria, string imagem)
        {
            //nomes, ids e preços?

            this.productID = ID;
            this.productName = name;
            this.Price = preço;
            this.Description = descriçao;
            this.Warranty = garantia;
            this.Category = categoria;
            this.Image = imagem;
        }

        public override string ToString()
        {
            return "ID do produto: " + this.productID + "\nNome do produto: " + this.productName +
                "\nPreço: " + this.Price + "\nDescrição: " + this.Description + "\nGarantia: "
                + this.Warranty + "\nCategoria: " + this.Category + "\nImagem: " + this.Image;
        }

        public string Pesquisa_Produto(Product[] vetor, string nome)
        {
            //função para pesquisar um produto

            string resultado = "O produto não existe...";

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].productName == nome)
                {
                    resultado = vetor[i].ToString();
                }
            }

            return resultado;
        }

        public string Pesquisa_Categoria(Product[] vetor, string nome)
        {
            //função para pesquisar uma categoria

            string resultado = "A categoria não existe...";

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Category == nome)
                {
                    resultado = vetor[i].ToString();
                }
            }

            return resultado;
        }
    }
}
