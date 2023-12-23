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
using Loja_Online_POO.Classes;

namespace Loja_Online_POO.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes novoCliente { get; set; }
        List<Cliente> cliente = LoadHelp.LoadFromFile<Cliente>("clientes.txt");

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Listar()
        {
            dataGridView1.Rows.Clear();



            if (cliente == null || cliente.Count == 0)
            {
                MessageBox.Show("Sem clientes disponíveis."); //MessageBoxButtons.OK);
            }
            else
            {
                foreach (var c in cliente)
                {
                    dataGridView1.Rows.Add(c.Nome, c.NIF, c.Morada, c.Email);
                }
            }



            int lastRowIndex = dataGridView1.Rows.Count - 1;
            if (lastRowIndex < 0 || !dataGridView1.Rows[lastRowIndex].IsNewRow)
            { 
                dataGridView1.Rows.Add("", "", "", "");
            }

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botao para ler a lista de clientes

            cliente = LoadHelp.LoadFromFile<Cliente>("clientes.txt");
            MessageBox.Show("Lista Lida!", "Lista" , MessageBoxButtons.OK);
            Listar();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //botao que chama a funcao savetofile e guarda num ficheiro .txt
        private void button2_Click(object sender, EventArgs e)
        {
            SaveClientesToFile("clientes.txt");
            MessageBox.Show("Lista Guardada!");
            
        }


        //funcao recebe os valores inseridos nas tabelas e imprime num ficheiro .txt
        private void SaveClientesToFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string nome = row.Cells[0].Value?.ToString();
                        string nif = row.Cells[1].Value?.ToString();
                        string morada = row.Cells[3].Value?.ToString();
                        string email = row.Cells[2].Value?.ToString();

                        if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(nif)
                            && !string.IsNullOrEmpty(morada) && !string.IsNullOrEmpty(email))
                        {
                            sw.WriteLine($"Nome* {nome}« NIF* {nif}« Morada* {morada}« Email* {email}");
                        }
                    }
                }
            }
        }
    }
}
