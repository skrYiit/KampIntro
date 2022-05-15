using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {

            //başvuran bilgilerini değerlendirme.
            //
            //aşşağıda yaptığımız şey yanlış çünkü başvurulan bütün kredileri konut kredisine göre hesaplattırıcaz.Doğrusu yukarı parametre vermek.

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
             


        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
