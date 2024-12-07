using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda
{
    internal class Producto
    {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
        public Image Imagen { get; set; }
        public int Cantidad { get; set; } 

        public Producto(int productid, string code, string name, string description, decimal price, int stock, string imagePath)
        {
            ProductID = productid;
            Code = code;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            ImagePath = imagePath;
            Imagen = Image.FromFile(imagePath);
            Cantidad = 0; 
        }
    }
}
