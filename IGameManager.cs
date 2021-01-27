using System;
using System.Collections.Generic;
using System.Text;

namespace OyunMeclisi
{
    interface IGameManager
    {
        public string GameId { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
    }
    class Games :IGameManager
    {
        
        
        public string GameId { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
        
        public void Purchase(Member member,CampaignManager game)
        {
            if (game.DiscountRate!=0)
            {
                game.NewPrice=(game.Price*(100-game.DiscountRate))/100;
                Console.WriteLine("Bağlanılan OyunMeclisi hesabı: "+member.NickName+"  "+game.GameName+" adlı oyunu" +game.NewPrice+" fiyatına aldınız. Kütüphanenize eklendi.");
            }
            else
            {
                Console.WriteLine("Bağlanılan OyunMeclisi hesabı: " + member.NickName + "  " + game.GameName + " adlı oyunu " + game.Price + " fiyatına aldınız. Kütüphanenize eklendi.");
                
            }
        }
    }
    class CampaignManager : Games
    {
        public CampaignManager()
        {
            DiscountRate = 0;
        }
        public int DiscountRate { get; set; }
        public double NewPrice { get; set; }
        public void AddCampaign(CampaignManager game,int discinput)
        {
            game.DiscountRate = discinput;
        }
        public void UpdateCampaign(CampaignManager game, int newdisc)
        {
            game.DiscountRate = newdisc;
        }
        public void DeleteCampaign(CampaignManager game)
        {
            game.DiscountRate = 0;
        }
    }
}
