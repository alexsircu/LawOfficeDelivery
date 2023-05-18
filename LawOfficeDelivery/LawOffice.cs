using LawOfficeDelivery.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawOfficeDelivery.Interface;

namespace LawOfficeDelivery
{
    internal class LawOffice
    {
        OfficeManager _officeManager;
        TranslationOffice _translationOffice;
        FoodDeliveryOffice _foodDeliveryOffice;
        FoodDelivery _foodDelivery;
        TranslationDelivery _translationDelivery;

        public OfficeManager OfficeManagerProp { get => _officeManager; set => _officeManager = value; }
        public TranslationOffice TranslationOfficeProp { get => _translationOffice; set => _translationOffice = value; }
        public FoodDeliveryOffice FoodDeliveryOfficeProp { get => _foodDeliveryOffice; set => _foodDeliveryOffice = value; }
        public FoodDelivery FoodDelivery { get => _foodDelivery; set => _foodDelivery = value; }
        public TranslationDelivery TranslationDelivery { get => _translationDelivery; set => _translationDelivery = value; }

        public LawOffice(FoodDelivery foodDelivery, TranslationDelivery translationDelivery) 
        {
            OfficeManagerProp = new OfficeManager(this);
            TranslationOfficeProp = new TranslationOffice();
            FoodDeliveryOfficeProp = new FoodDeliveryOffice();
            AddFoodDelivery(foodDelivery);
            AddTranslationDelivery(translationDelivery);
        }

        private void AddFoodDelivery(FoodDelivery foodDelivery)
        {
            if (foodDelivery is null) return;
            FoodDelivery = foodDelivery;
        }

        private void AddTranslationDelivery(TranslationDelivery translationDelivery)
        {
            if (translationDelivery is null) return;
            TranslationDelivery = translationDelivery;
        }

        #region OfficeManagerClass
        internal class OfficeManager : Person, IOfficeFactory
        {
            LawOffice _office;

            public LawOffice Office { get => _office; set => _office = value; }

            public OfficeManager(LawOffice office)
            {
                Office = office;
            }

            public void Order(char letter)
            {
                IDeliveryFactory internalOffice = GetOffice(letter);
                if (internalOffice is TranslationOffice)
                {
                    internalOffice.GetDelivery(Office.TranslationDelivery);
                }
                if (internalOffice is FoodDeliveryOffice)
                {
                    internalOffice.GetDelivery(Office.FoodDelivery);
                }
            }

            public IDeliveryFactory GetOffice(char letter)
            {
                if (letter == 'T') return Office.TranslationOfficeProp;
                if (letter == 'C') return Office.FoodDeliveryOfficeProp;
                return null;
            }
        }
        #endregion

        #region TranslationOfficeClass
        internal class TranslationOffice : IDeliveryFactory
        {
            public void GetDelivery(IProviderFactory delivery)
            {
                delivery.Order();
                Console.WriteLine("Dentro GetDelivery come translation");
            }
        }
        #endregion

        #region FoodDeliveryOfficeClass
        internal class FoodDeliveryOffice : IDeliveryFactory
        {
            public void GetDelivery(IProviderFactory delivery)
            {
                delivery.Order();
                Console.WriteLine("Dentro GetDelivery come food");
            }
        }
        #endregion
    }
}
