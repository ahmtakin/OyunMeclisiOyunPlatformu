using System;
using System.Collections.Generic;

namespace OyunMeclisi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nicknames = new List<string> {  };// nicknameler burada olacak 
            List<string> userinput1 = new List<string> { "1", "Ahmet", "Akin", "2002", "ahmetakin" };
            List<string> userinput2 = new List<string> { "2", "Taha", "Cap", "2002", "tahacap" };
            List<string> userinput3 = new List<string> { "3", "Hakan", "Yalcinkaya", "2002", "etrichbarys" };// aynı kullanıcı adı isteği
            List<string> userinput4 = new List<string> { "4", "Eren Batuhan", "Yılmaz", "2002", "etrichbarys" };//aynı kullanıcı adı isteği
            List<string> userinput5 = new List<string> { "5", "Hasan", "Ali", "2003", "caferali" }; // bu adla sistemde bir isim yok



            Member member1 = new Member() { BirthYear = "2002", FirstName = "Ahmet", LastName = "Akin", TcNo = "1" };// e devlette kayıtlı özellikler
            Member member2 = new Member() { BirthYear = "2002", FirstName = "Taha", LastName = "Cap", TcNo = "2" };
            Member member3 = new Member() { BirthYear = "2002", FirstName = "Hakan", LastName = "Yalcinkaya", TcNo = "3" };
            Member member4 = new Member() { BirthYear = "2002", FirstName = "Eren Batuhan", LastName = "Yılmaz", TcNo = "4" };
            Member member5 = new Member() { BirthYear = "2003", FirstName = "Cafer", LastName = "Ali", TcNo = "5" };
            member1.CheckNAdd(nicknames, userinput1, member1);
            member2.CheckNAdd(nicknames, userinput2, member2);
            member3.CheckNAdd(nicknames, userinput3, member3);
            member4.CheckNAdd(nicknames, userinput4, member4);
            member5.CheckNAdd(nicknames, userinput5, member5);

            member3.Delete(nicknames, userinput3);
            member2.Update(nicknames, userinput2, member2, "kokomonci");
            member1.Update(nicknames, userinput1, member1, "padawan");

            CampaignManager game1 = new CampaignManager() { GameId = "45", GameName = "csgo", Price = 100 };
            CampaignManager game2 = new CampaignManager() { GameId = "12", GameName = "cyberpunk2077", Price = 250 };
            CampaignManager game3 = new CampaignManager() { GameId = "75", GameName = "Need For Speed", Price = 120 };
            CampaignManager game4 = new CampaignManager() { GameId = "35", GameName = "fifa20", Price = 200 };
            game4.AddCampaign(game4, 25);
            game4.Purchase(member1, game4);
            game2.AddCampaign(game2, 10);
            game2.Purchase(member2, game2);
            game2.UpdateCampaign(game2,25);
            game2.Purchase(member1, game2);
            game3.Purchase(member1, game3);
        }
    }
}
