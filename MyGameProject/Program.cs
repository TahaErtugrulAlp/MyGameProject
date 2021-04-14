using MyGameProject.Concrete;
using MyGameProject.Entities;
using System;

namespace MyGameProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Ertuğrul";
            customer.LastName = " Alp";
            customer.IdentityNumber = " 485645342342";
            customer.DateOfBirth = 2002;


            SpecialOffer specialOffer = new SpecialOffer();
            specialOffer.SpecialOfferId = 1;
            specialOffer.SpecialOfferType = " %50 indirimle";
            specialOffer.SpecialOfferActive = true;

            SpecialOfferManager specialOfferManager = new SpecialOfferManager();
            specialOfferManager.AddSpecialOffer(specialOffer);

            CustomerManager customerManager = new CustomerManager();
            customerManager.SignUp(customer);

            GamerMarketManager gamerMarketManager = new GamerMarketManager();
            gamerMarketManager.BuyGames(specialOffer);

            specialOfferManager.DeleteSpecialOffer(specialOffer);





        }
    }
}
