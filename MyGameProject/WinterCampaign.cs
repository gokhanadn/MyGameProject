using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class WinterCampaign : ICampaignService
    {
        public void Returnit(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "adlı oyuncu kış kampanyasında iade yaptı.");
        }

        public void Sell(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "adlı oyuncu kış kampanyasında ürün sattı.");
        }
    }
}
