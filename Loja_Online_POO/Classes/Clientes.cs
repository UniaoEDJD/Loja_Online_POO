﻿using System;
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

namespace Loja_Online_POO.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        Clientes[] list = new Clientes[0];
        Clientes a;

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Listar()
        {
            //Funçao para listar os clientes
            if ( list == null || list.Length == 0)
            {
                dataGridView1.Rows.Clear();
                MessageBox.Show("Sem clientes disponiveis.");
            }
            else
            {
                dataGridView1.RowCount = list.Length;
                for (int i = 0; i < list.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = list[i].Nome;
                    dataGridView1.Rows[i].Cells[1].Value = list[i].NIF;
                    dataGridView1.Rows[i].Cells[2].Value = list[i].Endereço;
                    dataGridView1.Rows[i].Cells[3].Value = list[i].morada;

                }
            }
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ficheiro = @"materiaisS.bin";

            if (File.Exists(ficheiro))
            {
                IFormatter formatadorBIN = new BinaryFormatter();
                FileStream fich = new FileStream(ficheiro, FileMode.Open);
                list = (Clientes[])formatadorBIN.Deserialize(fich);
                fich.Close();
                MessageBox.Show("Lista Lida!");
                Listar();
            }
        }
    }
}
