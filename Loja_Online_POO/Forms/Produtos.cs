using Loja_Online_POO.Classes;
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

namespace Loja_Online_POO.Forms
{
    public partial class Produtos : Form
    {
        List<Categoria> categorias = LoadHelp.LoadFromFile<Categoria>("categories.txt");
        List<Product> products = LoadHelp.LoadFromFile<Product>("products.txt");

        public Produtos()
        {
            InitializeComponent();
            PopDrop();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }


        public void PopDrop()
        {
            comboBox1.Items.Clear();
            foreach (var categoria in categorias)
            {
                comboBox1.Items.Add(categoria);
            }
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryID";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Categoria selectedCategoria = (Categoria)comboBox1.SelectedItem;
                int selectedCategoryID = selectedCategoria.CategoryID;

                Console.WriteLine($"Selected Category ID: {selectedCategoryID}");

                var filteredProducts = products.Where(p => p.ProductCatID == selectedCategoryID).ToList();
                PopulateProductComboBox(filteredProducts);
                
                
            }
        }


        private void PopulateProductComboBox(List<Product> productList)
        {
            try
            {
                // Populate product ComboBox
                comboBox2.DataSource = null; // Clear previous data
                comboBox2.DataSource = productList;
                comboBox2.DisplayMember = "productName";
                comboBox2.ValueMember = "productID";

                if (productList.Count > 0)
                {
                    // Display details of the first product in the list
                    DisplayProductDetails(productList[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating product ComboBox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                // Display details of the selected product
                Product selectedProduct = (Product)comboBox2.SelectedItem;
                DisplayProductDetails(selectedProduct);
            }
        }

        private void DisplayProductDetails(Product product)
        {
            // Populate other text boxes with product details
            proMarca.Text = product.Marca.ToString();
            proID.Text = product.productID.ToString();
            proStock.Text = product.Stock.ToString();
            prodDesc.Text = product.Description.ToString();
            Warranty.Text = product.Warranty.ToString();
            prodPrice.Text = product.Price.ToString();
            pictureBox2.Image = LoadImage(product.ImagePath);
        }

        // Example method to load an image from file
        private Image LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }

            return null;
        }
    }
}
