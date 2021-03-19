using Odev1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Odev1.Data
{
    public sealed class DataProduct
    {
        private DataProduct()
        {
            FillData();
        }
        public List<ProductModel> Products = new List<ProductModel>();

        private void FillData()
        {
            string path = @"C:\Users\dilan\source\repos\KodluyoruzOdevlerim\Odev1\veri.txt";
            
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string veriler;
                
                for (int i = 1; i <= 20; i++)
                {
                    veriler = sr.ReadLine();
                    string[] veri = veriler.Split(",");
                    Products.Add(new ProductModel { Id = Convert.ToInt32(veri[0]), Name = veri[1], Price = Convert.ToInt32(veri[2]) });
                }
            }
            else
            {
                for (int i = 1; i <= 20; i++)
                {
                    Products.Add(new ProductModel { Id = i, Name = "Product_" + i, Price = 100 + (i * 10) });
                }
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < 20; i++)
                {
                    sw.WriteLine(Products[i].Id + "," + Products[i].Name + "," + Products[i].Price);
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            }

        }
   

        public static DataProduct Instance { get { return Nested.instance; } }

        private class Nested
        { 
            static Nested()
            { }

            internal static readonly DataProduct instance = new DataProduct();
        }
    }
}




   
