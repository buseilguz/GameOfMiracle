using System;

namespace GameOfMiracle
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            Console.WriteLine("Kullanıcı adını giriniz");
            gamer1.Name = Console.ReadLine();
            Console.WriteLine("Kullanıcı soyadını giriniz");
            gamer1.Surname = Console.ReadLine();
            Console.WriteLine("Kullanıcı TC Kimlik No  giriniz");
            gamer1.NationalityNumber = Console.ReadLine();
            Console.WriteLine("Kullanıcı doğum tarihini  giriniz(GGAAYYYY)");
            gamer1.DateTime = Convert.ToDateTime( Console.ReadLine());
            Random rastgele = new Random();
            gamer1.ID= Convert.ToString(rastgele.Next());

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);

            game game1 = new game();
            Console.WriteLine("Sisteme tanımlamak istediğiniz oyunu giriniz.");
            game1.GameName = Console.ReadLine();
            Console.WriteLine("Oyunun satış fiyatı nedir?");
            game1.GamePrice =Convert.ToInt32( Console.ReadLine());
            game1.GameID= rastgele.Next();
            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);



            campaigns campaign1 = new campaigns();
            Console.WriteLine("Oluşturacağınız kampanya adı nedir?");
            campaign1.CampaignName = Console.ReadLine();
            Console.WriteLine("Kampanya indirim oranını giriniz.(%) ");
            campaign1.DiscountRate = Convert.ToInt32(Console.ReadLine());

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.StartCampaign(campaign1,game1);

            SalesManager salesManager = new SalesManager();
            salesManager.SaleGame(game1, gamer1, campaign1);

        }
    }
}
