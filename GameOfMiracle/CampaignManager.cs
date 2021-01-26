using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfMiracle
{
    class CampaignManager: game
    {
        
        public void StartCampaign(campaigns campaign,game game)
        {
          
            
            Console.WriteLine( " {0} isimli kampanya alınan oyuna uygulandı.Almış olduğunuz indirim sonrası fiyat:{1} ",campaign.CampaignName,Convert.ToString(game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100)));

        }
        public void FinishCampaign(campaigns campaign)
        {
            Console.WriteLine("{0} kampanyası sonlandırıldı.",campaign);
        
        }




    }
}
