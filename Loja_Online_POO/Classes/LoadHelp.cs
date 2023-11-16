using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Reflection;

namespace Loja_Online_POO.Classes
{
    public static class LoadHelp
    {
        // funcao generica que pode carregar tanto os produtos como as categorias a partir dos seus respetivos ficheiros .txt
        public static List<T> LoadFromFile<T>(string fileName) where T : new()
        {
            List<T> items = new List<T>();

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length > 0)
                    {
                        T item = new T();

                        foreach (string part in parts)
                        {
                            string[] keyValue = part.Split(':');
                            if (keyValue.Length == 2)
                            {
                                string propertyName = keyValue[0].Trim();
                                string propertyValue = keyValue[1].Trim();

                                Console.WriteLine($"Debug: PropertyName: {propertyName}, PropertyValue: {propertyValue}");

                                PropertyInfo property = typeof(T).GetProperty(propertyName);
                                if (property != null)
                                {                                                                                                           
                                            TypeConverter typeConverter = TypeDescriptor.GetConverter(property.PropertyType);
                                            object convertedValue = typeConverter.ConvertFromString(propertyValue);
                                            property.SetValue(item, convertedValue);                                                                           
                                }
                                else
                                {
                                    Console.WriteLine($"Error: Property {propertyName} not found in class {typeof(T).Name}");
                                }
                            }
                        }

                        items.Add(item);
                    }
                }
            }
            else
            {
                File.Create(fileName).Close();
            }

            return items;
        }
    }
}
