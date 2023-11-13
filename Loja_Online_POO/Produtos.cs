using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO
    {      
        internal class Produtos
        { 
        public string Descricao {get; set;}
        public double Preco {get; set;}
        public int Stock {get; set;}
        public int Garantia {get; set;}
        public string Marca {get; set;}

        public Categorias()
        {
            Descricao = "Vazio";
            Preco = 0;
            Stock = 0;
            Garantia = 0;
            Marca = "N\A";
        }
        }
    }