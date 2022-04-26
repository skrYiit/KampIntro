using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.Aciklama = "Amasya";
            product1.Fiyat = 15;

            Product product2 = new Product();
            product2.ProductName ="Karpuz";
            product2.Aciklama = "Diyarbakır";
            product2.Fiyat = 20;

            Product[] products = new Product[] {product1 , product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("----------------Metotlar--------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
        }   
    }
}

//Tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.(Metotlar),DRY
