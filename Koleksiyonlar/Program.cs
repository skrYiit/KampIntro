using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////arraylar oluşturduğumuz sınırlar kadardır.o yüzden 19.satırda hata alırız.
            //string[] isimler = new string[] {"yiğit","faho","afa","sero"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            // //isimler[4] = "samed";
            ////Console.WriteLine(isimler[4]);
            //isimler = new string[5]; // yeni referans atadığımız için diğer elemanlar yok oldu.
            //isimler[4] = "aykut";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            /*
            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");
            ister böyle ekleme yaparım ister aşağıdaki gibi tanımlarım.
            */
            List<string> isimler2 = new List<string> { "yiğit", "faho", "afa", "sero" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("samed");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}
