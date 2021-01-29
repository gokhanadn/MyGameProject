using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface ICampaignService
    {
        void Sell(Gamer gamer);
        void Returnit(Gamer gamer);
    }
}
