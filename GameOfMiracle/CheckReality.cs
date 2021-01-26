using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfMiracle
{
    class CheckReality:Gamer
    {
        public CheckReality(Gamer gamer)
        {
            if ( gamer.NationalityNumber.Length == 11)
            {
                Console.WriteLine("{0}{1} adlı kullanıcı veritabanına kaydedildi.", gamer.Name, gamer.Surname);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir TC Kimlik No ile giriş yapın");
            }

        }

    }
}
