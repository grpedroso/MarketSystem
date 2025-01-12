using MarketSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSystem.Service
{
    public class ProductService
    {
        private const string FileName = "products.json";

        public void SaveProducts(Dictionary<int, Product> product)
        {
            string json = JsonConvert.SerializeObject(product);
            string filePath = Path.Combine(FileSystem.AppDataDirectory, FileName);
            File.WriteAllText(filePath, json);
        }

        public Dictionary<int, Product> LoadProduct()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, FileName);
            if (!File.Exists(filePath))
            {
                return new Dictionary<int, Product>();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<int, Product>>(json);
        }


    }
}
