using Loja_Online_POO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Loja_Online_POO
{
    public partial class addCat : Form
    {
        private OnlineShop onlineShop;
        public Categoria NovaCat { get; set; }
        


        public addCat(OnlineShop shop)
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
                    NovaCat = new Categoria
                        {
                        CategoryID = catID,
                        Name = nomeCat
                        };
                    onlineShop.Categorias.Add(NovaCat);

                    onlineShop.SaveCat();

                 }
                    
             }
   
            else
            {
                MessageBox.Show("error", "error");
            }
         

        

        }
    }
}
