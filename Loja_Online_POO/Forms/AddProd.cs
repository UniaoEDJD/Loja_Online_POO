using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Online_POO.Classes
{
    public partial class AddProd : Form
    {
        string defaultPath = Directory.GetCurrentDirectory() + "\\imagens";
        //inicializacao das Listas e do novo produto
        public Product novoProd { get; set; }
        List<Categoria> categorias = LoadHelp.LoadFromFile<Categoria>("categories.txt");
        List<Product> products = LoadHelp.LoadFromFile<Product>("products.txt");
        

        public AddProd()
        {
            InitializeComponent();
            PopulateCatDrop();
            this.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox2.DragDrop += pictureBox2_DragDrop;
            pictureBox2.DragEnter += pictureBox2_DragEnter;
            this.DragEnter += pictureBox2_DragEnter;
            this.DragDrop += pictureBox2_DragDrop;
            novoProd = new Product();
        }


        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                if (!Directory.Exists(defaultPath))
                {
                    Directory.CreateDirectory(defaultPath);
                }

                string imagePath = files[0];
                string fileName = Path.GetFileName(imagePath);
                string destinationPath = Path.Combine(defaultPath, fileName);

                File.Copy(imagePath, destinationPath);

                pictureBox2.Image = Image.FromFile(destinationPath);

                novoProd.ImagePath = destinationPath;
            }
        }
        //funcao que vai a lista categorias e procura no ficheiro texto o nome e id e popula a lista com o nome, e atribui o respetivo ID
        public void PopulateCatDrop()
        {
            
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryID";
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string xImage;

        //botao que busca todos os valores inseridos e guarda
        private void button1_Click(object sender, EventArgs e)
        {
            int proID = Int32.Parse(prodID.Text);
            string proName = this.proName.Text;
            string Desc = prodDesc.Text;
            string marca = ProdMarca.Text;
            int warr = Int32.Parse(Warranty.Text);          
            double price = Double.Parse(prodPrice.Text);
            int selectedCategoryID = (int)comboBox1.SelectedValue;
            int stock = Int32.Parse(stockBox.Text);
         

            if (!String.IsNullOrEmpty(prodID.Text)) 
            {
                novoProd = new Product
                {
                    productID = proID,
                    productName = proName,
                    Description = Desc,
                    Marca = marca,
                    Warranty = warr,
                    ProductCatID = selectedCategoryID,
                    Price = price,
                    Stock = stock,
                    ImagePath = novoProd.ImagePath

                   
                };
                SaveProductToFile(novoProd);
            }
        }

        private void prodDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProd_Load(object sender, EventArgs e)
        {

        }

        private void retornar_Click(object sender, EventArgs e)
        {
            //botao para esconder o forms

            this.Hide();
        }


        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

       

        //funcao que guarda os valores num ficheiro .txt
        public void SaveProductToFile(Product product)
        {
            string fileName = "products.txt";

            // Confirm if the product already exists
            if (products.Any(p => p.productID == product.productID))
            {
                MessageBox.Show("Erro: Produto com o mesmo ID já existe.", "Erro");
                return;
            }

            // Vai á funçao internal criar a linha dentro do ficheiro .txt
            SaveProductToFileInternal(product);

            
            products.Add(product);

            MessageBox.Show("Produto guardado com sucesso!", "Sucesso");
        }

        public void SaveProductToFileInternal(Product product)
        {
            string fileName = "products.txt";


            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine($"productID* {product.productID}, productName* {product.productName}, " +
                             $"Price* {product.Price}, Description* {product.Description}, " +
                             $"Warranty* {product.Warranty}, Marca* {product.Marca}, " +
                             $"CategoryID* {product.ProductCatID}, Stock* {product.Stock}, " +
                             $"ImagePath* {product.ImagePath}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //botao para escolher a imagem

            if (!Directory.Exists(defaultPath))
            {
                Directory.CreateDirectory(defaultPath);
            }

            string caminho = defaultPath;
            openFileDialog1.Filter = "Imagens|*.jpg;*.png;*.jeg";
            string imagem = "";

            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagemselect = openFileDialog1.FileName;
                string Nomefich = Path.GetFileName(imagemselect);
                string destinationpath = Path.Combine(caminho, Nomefich);
                System.IO.DirectoryInfo caminhoficheiro = new DirectoryInfo(openFileDialog1.FileName);
                imagem = caminhoficheiro.Name;
                File.Copy(imagemselect, destinationpath, true);
                pictureBox2.Image = Image.FromFile(caminho + "\\" + Nomefich);
                novoProd.ImagePath = caminho + "\\" + Nomefich;
            }
            else
            {
                pictureBox2.Image = null;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
