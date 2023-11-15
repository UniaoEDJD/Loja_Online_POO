using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Loja_Online_POO.Classes
{
    public static class LoadHelp
    {
        public static List<Categoria> LoadCategoriesFromFile()
        {
            string fileName = "categories.txt";
            List<Categoria> categories = new List<Categoria>();

            if (File.Exists(fileName))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    // Split the line to extract CategoryID and Name
                    string[] parts = line.Split(',');

                    // Parse values
                    if (parts.Length == 2 && int.TryParse(parts[0].Split(':')[1].Trim(), out int categoryID))
                    {
                        string name = parts[1].Split(':')[1].Trim();

                        // Create Categoria object
                        Categoria category = new Categoria
                        {
                            CategoryID = categoryID,
                            Name = name
                        };

                        categories.Add(category);
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
   
                }
            }

            return categories;
        }
    }
}
