using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Loja_Online_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        public static Form Formprincipal = null;
        public static string nome = null;

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da loja?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "adminpotente")
            {
                MessageBox.Show("Registo executado com sucesso!", "Registo", MessageBoxButtons.OK);

                Formprincipal = this;
                StoreFront f2 = new StoreFront();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("O nome de usuário ou a passdword está errada.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
          
        }
    }
}
