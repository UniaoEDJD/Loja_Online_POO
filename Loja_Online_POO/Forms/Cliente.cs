﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Online_POO.Classes
{
    class Cliente 
    {
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }

        public Cliente()
        {
            this.Nome = "";
            this.NIF = "";
            this.Email = "";
            this.Morada = "";
        }

        public Cliente(string nome, string nif, string email, string morada)
        {
            this.Nome = nome;
            this.NIF= nif;
            this.Email = email;
            this.Morada = morada;
        }

    }
}
