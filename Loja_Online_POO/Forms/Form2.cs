﻿using Loja_Online_POO.Classes;
using Loja_Online_POO.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Online_POO
{
    public partial class StoreFront : Form
    {
        bool isbtnvis;
        public StoreFront()
        {
            InitializeComponent();
        }

        private void StoreFront_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botao terminar sessao

            if (MessageBox.Show("Deseja terminar sessão?", "Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginmenu = new Form1();
                loginmenu.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abrir e fechar painel

            panel2.Visible = !panel2.Visible;
            isbtnvis = !isbtnvis;
            addCat.Visible = isbtnvis;
            verEnc.Visible = isbtnvis;
            AddProd.Visible = isbtnvis;
            editList.Visible = isbtnvis;
        }

        private void NavCat_Click(object sender, EventArgs e)
        {
            Produtos Ver = new Produtos();
            Ver.Show();
        }

        private void addCat_Click(object sender, EventArgs e)
        {
            //botao adicionar categoria e esconde o forms2
            addCat ACA = new addCat();
            ACA.Show();
        }

        private void AddProd_Click(object sender, EventArgs e)
        {
            //botao para abrir o forms para adicionar um produto

            AddProd addProd = new AddProd();
            addProd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //botao para abrir o forms clientes

            Clientes clin = new Clientes();
            clin.Show();
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            //botao sair da app

            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
