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
        public Categoria NovaCat { get; set; }



        public addCat()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCat = textBox1.Text;
            string catstringID  = textBox2.Text;
            int catID;


            if (!string.IsNullOrEmpty(nomeCat))
            {
                if (!string.IsNullOrEmpty(catstringID) && int.TryParse(catstringID, out catID))
                {
                    NovaCat = new Categoria();
                    {
                        productID = catID;
                        productname = nomeCat;
                    }
                 SaveCategoryToFile(NovaCat);
                }
                    
            } 
            else
            {
                MessageBox.Show("error", "error");
            }
        }



        //funcao que cria e guarda o nome e o id da categoria por linhas num ficheiro .txt
        private void SaveCategoryToFile(Categoria categoria) 
        {
            string filename = "categorias.txt";
                
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine($"CategoryID: {categoria.CategoryID}, Name: {categoria.Name}");
            }
            MessageBox.Show("Category Saved Succesfuly.", "Sucess");
        }
    }
}
