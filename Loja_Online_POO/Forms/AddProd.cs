using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Online_POO.Classes
{
    public partial class AddProd : Form
    {
        public List<Categoria> categories = LoadHelp.LoadCategoriesFromFile();
        public AddProd()
        {
            InitializeComponent();
            PopulateCatDrop();
        }

        public void PopulateCatDrop()
        {
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryID";
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
