using System;
 using System.Collections.Generic;
using System.Text;

namespace GameOfMiracle
{
    class GameManager
    {
        public void AddGame(game game)
        {
            Console.WriteLine("{0} isimli oyun sisteme tanımlandı", game.GameName);

        }
        public void UpdateGame(game game)
        {

            Console.WriteLine(" {0} oyununda istediğiniz özellikler güncellendi",game.GameName);
        }
         
        public void RemoveGame(game game)
        {
            Console.WriteLine("{0} isimli oyun silindi",game.GameName);
        }


    }
}
       
    

