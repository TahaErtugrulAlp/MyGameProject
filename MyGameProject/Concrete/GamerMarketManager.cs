using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    public class GamerMarketManager : IGamerMarketService
    {
        public void BuyGames(SpecialOffer specialOffer)
        {
            if (specialOffer.SpecialOfferActive)
            {
                Console.WriteLine("Oyunu indirim ile satın aldınız.");
            }
            else
            {
                Console.WriteLine("Oyunu satın aldınız.");
            }
        }
    }
}
