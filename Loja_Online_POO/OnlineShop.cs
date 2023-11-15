using Loja_Online_POO.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


public class OnlineShop
{

    public List<Categoria> Categorias { get; set; }

    public OnlineShop()
    {
        Categorias = new List<Categoria>();
    }
    public void SaveCat()
    {
        StringBuilder sb = new StringBuilder();

        foreach (Categoria category in Categorias)
        {
            sb.AppendLine($"{category.CategoryID},{category.Name}");
        }
        File.WriteAllText("categories.txt", sb.ToString());
    }
}