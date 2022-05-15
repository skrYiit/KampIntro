using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager
    {
        //hesaplamayı bütün kredilerde kullanacağız fakat,her birinin farklı koşullara sahip olduğundan farklı şekilde kullanacağımızdan intreface kullanırız.Her biri bu şablonu içermeli.
         void Hesapla();
        void BiseyYap();
    }
}
