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

        List<Categoria> categorias = LoadHelp.LoadCategoriesFromFile();



        public addCat()
        {
            InitializeComponent();

            
        }




        private void button1_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("error", "error");
            }
        }
        public void SaveCategoriaToFile(Categoria categoria)
        {
            string fileName = "categories.txt";

            // Check if the categoria already exists
            if (categorias.Any(cat => cat.CategoryID == categoria.CategoryID || cat.Name == categoria.Name))
            {
                MessageBox.Show("Error: Categoria with the same ID or Name already exists.", "Error");
                return;
            }

            // Save the new categoria to the file
            SaveCategoriaToFileInternal(categoria);

            // Update the in-memory collection
            categorias.Add(categoria);

            MessageBox.Show("Categoria saved successfully.", "Success");
        }

        public void SaveCategoriaToFileInternal(Categoria categoria)
        {
            string fileName = "categories.txt";

            // Open the file for writing
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                // Append the new categoria information to the file
                sw.WriteLine($"CategoryID: {categoria.CategoryID}, Name: {categoria.Name}");
            }
        }

    }

}
