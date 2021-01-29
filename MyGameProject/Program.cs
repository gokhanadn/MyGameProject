using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer oyuncu1 = new Gamer() { FirstName = "Gökhan", LastName = "Aydın", BirthYaer = 2000, ID = 1, TC = 11111111111 };
            GamerManager gamerManager = new GamerManager();
            ICampaignService kiskampanyasi1 = new WinterCampaign();
            ICampaignService kiskampanyasi2 = new WinterCampaign();

            ValidationManager dogrulama = new ValidationManager();
            dogrulama.Validate(oyuncu1);
            gamerManager.Add(oyuncu1);
            kiskampanyasi1.Sell(oyuncu1);
            
            
        }
    }
}
