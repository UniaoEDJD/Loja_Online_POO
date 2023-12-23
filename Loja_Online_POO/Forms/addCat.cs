using Loja_Online_POO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    

namespace Loja_Online_POO
{

    public partial class addCat : Form
    {
        
        public Categoria NovaCat { get; set;}

        List<Categoria> categorias = LoadHelp.LoadFromFile<Categoria>("categories.txt");



        public addCat()
        {
            InitializeComponent();

            
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //botao para guardar categoria

            string nomeCat = textBox1.Text;
            string catstringID = textBox2.Text;
            int catID;


            if (!string.IsNullOrEmpty(nomeCat))
            {
                if (!string.IsNullOrEmpty(catstringID) && int.TryParse(catstringID, out catID))
                {
                    NovaCat = new Categoria
                    {
                        CategoryID = catID,
                        Name = nomeCat
                    };
                    SaveCategoriaToFile(NovaCat);
                }

            }
            else
            {
                MessageBox.Show("Erro", "Erro"); /*MessageBoxIcon.Exclamation*/
            }
        }



        //funcao que guarda o nome e id da categoria num ficheiro .txt
        public void SaveCategoriaToFile(Categoria categoria)
        {
            string fileName = "categories.txt";

            //Confirma se a categoria ja existe
            if (categorias.Any(cat => cat.CategoryID == categoria.CategoryID || cat.Name == categoria.Name))
            {
                MessageBox.Show("Erro: Categoria com o mesmo ID ou Nome já existe.", "Erro");
                return;
            }

            //Guarda a nova categoria
            SaveCategoriaToFileInternal(categoria);

            //Atualiza a coleçao da memoria
            categorias.Add(categoria);

            MessageBox.Show("Categoria guardada com sucesso.", "Sucesso");
        }




        public void SaveCategoriaToFileInternal(Categoria categoria)
        {
            string fileName = "categories.txt";

            //Abre o ficheiro para escrever
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                //Guarda a nova categoria no ficheiro 
                sw.WriteLine($"CategoryID* {categoria.CategoryID}« Name* {categoria.Name}");
            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            //botao para retornar ao forms2
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCat_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
