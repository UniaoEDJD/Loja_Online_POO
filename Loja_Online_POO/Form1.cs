using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Loja_Online_POO
{
    public partial class Form1 : KryptonForm
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

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = "Admin";

            if (text == "Admin")
            {
                MessageBox.Show("Nome de Usuário correto.");
            }
            else
            {
                MessageBox.Show("Nome de Usuário incorreto.\n Tente novamente!");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             string pass = textBox2.Text;
             textBox2.Text = "lojaonline";

            if (textBox2.Text == pass)
            {
                MessageBox.Show("Password correta.");
            }
            else
            {
                MessageBox.Show("Password incorreta.\n Tente novamente.");
            }
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
            MessageBox.Show("Registo executado com sucesso!", "Registo", MessageBoxButtons.OK);

            Formprincipal = this;
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
