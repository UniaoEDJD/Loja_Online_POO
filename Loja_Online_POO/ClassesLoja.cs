﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Online_POO
{
    internal class ClassesLoja
    {
        public string conta {  get; set; }
        public int dinheiro { get; set; }
        public string caixacorreio { get; set; }

        public ClassesLoja(string nome, int saldo, string email) 
        {
            conta = nome;
            dinheiro = saldo;
            caixacorreio = email;
        }



        
    }
}
