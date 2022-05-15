using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface'lerde referans numarası tutabiliyor.
            IKrediManager ihtiyacKrediManager1 = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager(); 
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {databaseLoggerService,smsLoggerService });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager1 , tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
