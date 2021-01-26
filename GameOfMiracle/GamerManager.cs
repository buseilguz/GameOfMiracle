using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfMiracle
{
    class GamerManager:Gamer
    {
       
        public void Add(Gamer gamer)
            
        {
            CheckReality checkReality = new CheckReality(gamer); ;
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0}{1} adlı kullanıcı veritabanında güncellendi.",gamer.Name,gamer.Surname);
  
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0}{1} adlı kullanıcı veritabanından silindi.", gamer.Name, gamer.Surname);
        }
    
    
    }
}
