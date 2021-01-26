using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfMiracle
{
    class SalesManager: Gamer
    {
        public void SaleGame(game game,Gamer gamer,campaigns campaign)
        {
            Console.WriteLine("Satış Bilgileri\n--------------\nSatın Alınan Oyun:{0}\nSatın Alan Oyuncu :{1}\nSatışBedeli:{2}",game.GameName,gamer.Name+gamer.Surname, Convert.ToString(game.GamePrice - (game.GamePrice * campaign.DiscountRate/100)));
        
        }



    }
}
