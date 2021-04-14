using MyGameProject.Abstract;
using MyGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameProject.Concrete
{
    public class SpecialOfferManager : ISpecialOfferService
    {
        public void AddSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferActive = true;
            Console.WriteLine("New Campaign" + specialOffer.SpecialOfferType +"kampanya eklendi.");

        }

        public void DeleteSpecialOffer(SpecialOffer specialOffer)
        {
            specialOffer.SpecialOfferActive = false;
            Console.WriteLine("Campaign" + specialOffer.SpecialOfferType +"kampanya kaldırıldı.");
           
        }

        public void UpdateSpecialOffer(SpecialOffer specialOffer)
        {
            Console.WriteLine("Campaign" + specialOffer.SpecialOfferType + "güncellendi.");

        }
    }
}
