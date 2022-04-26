using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //claslar ikiye ayrılılr.1 içinde özellik barındıranlar.2 opersayon barındıranlar yani metod.
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;
            Console.WriteLine(product1.ProductName);

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kale", UnitPrice = 35 };

            //Pascalcase   //camelcase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            /*
            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);
            
            Console.WriteLine(toplamaSonucu*2);
            return sayesinde deger döndürüp sonrasında kullanabiliyoruz. 
            */

        }
    }
}
