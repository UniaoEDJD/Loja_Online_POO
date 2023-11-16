﻿using System;
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

        
        public Product novoProd { get; set; }
        List<Categoria> categorias = LoadHelp.LoadFromFile<Categoria>("categories.txt");
        List<Product> products = LoadHelp.LoadFromFile<Product>("products.txt");
        public AddProd()
        {
            InitializeComponent();
            PopulateCatDrop();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            int proID = Int32.Parse(prodID.Text);
            string proName = this.proName.Text;
            string Desc = prodDesc.Text;
            string marca = ProdMarca.Text;
            int warr = Int32.Parse(Warranty.Text);          
            double price = Double.Parse(prodPrice.Text);
            int selectedCategoryID = (int)comboBox1.SelectedValue;


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
                    Price = price
                };
                SaveProductToFile(novoProd);
            }
        }

        public void SaveProductToFile(Product product)
        {
            string fileName = "products.txt";

            // Confirm if the product already exists
            if (products.Any(p => p.productID == product.productID || p.productName == product.productName))
            {
                MessageBox.Show("Error: Product with the same ID already exists.", "Error");
                return;
            }

            // Save the new product
            SaveProductToFileInternal(product);

            // Update the in-memory collection
            products.Add(product);

            MessageBox.Show("Product saved successfully.", "Success");
        }

        public void SaveProductToFileInternal(Product product)
        {
            string fileName = "products.txt";

 
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                sw.WriteLine($"ProductID: {product.productID}, Name: {product.productName}, " +
                             $"Price: {product.Price}, Description: {product.Description}, " +
                             $"Warranty: {product.Warranty}, Marca: {product.Marca}, " +
                             $"CategoryID: {product.ProductCatID}");
            }
        }

        private void prodDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
